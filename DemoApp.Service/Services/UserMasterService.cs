using DemoApp.DataAccess.Models;
using DemoApp.Service.Helpers;
using DemoWebApi.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DemoApp.Service
{
    public class UserMasterService : IUserMasterService
    {
        private readonly AppSettings _appSettings;
        private readonly PMIContext _db;
        public UserMasterService(IOptions<AppSettings> appSettings, PMIContext db)
        {
            _appSettings = appSettings.Value;
            _db = db;
        }

        private readonly List<UserMasters> _users = new List<UserMasters>
        {
            new UserMasters { UserId = 1, FirstName = "Test", LastName = "User", UserName = "test", Password = "test" },
            new UserMasters { UserId = 2, FirstName = "Rekha", LastName = "Rana", UserName = "rekharana", Password = "test" }
        };

        public UserMasters Authenticate(string username, string password)
        {

            var user = _db.UserMasters.SingleOrDefault(x => x.UserName == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserId", user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.FirstName.ToString() +" " +user.LastName.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.TokenId = tokenHandler.WriteToken(token);
            return user.WithoutPassword();
        }


        public IEnumerable<UserMasters> GetAll()
        {
            return _db.UserMasters.ToList().WithoutPasswords();
        }


        public IEnumerable<User> GetAllUsers()
        {
            return _db.User.ToList().UserWithoutPasswords();
        }

        public User GetUserById(int userId)
        {
          return _db.User.Include(x=>x.Photo).FirstOrDefault(x => x.Id == userId).UserWithoutPassword().UserWithoutHashPasswords();                               

        }

        public async void Register(string username, byte[] passwordHash, byte[] passwordSalt)
        {               

            var UserMasters = new User() { Username = username.ToLower(), PasswordHash = passwordHash, PasswordSalt= passwordSalt };
            _db.User.Add(UserMasters);
            await _db.SaveChangesAsync();

        }

        public async Task<bool> UserExist(string username)
        {
            if (await _db.User.AnyAsync(x => x.Username == username))
                return true;

            return false;
        }
        public async Task<User> Login(string username, string password) {
            var user = await _db.User.FirstOrDefaultAsync(x => x.Username == username);
            if (user==null)            
                return null;

            //if (!VerifyPasswordHash(password,user.PasswordHash, user.PasswordSalt))
            //    return null;


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserId", user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.KnownAs.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.TokenId = tokenHandler.WriteToken(token);
            return user.UserWithoutPassword();         

        }
        
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        public void Update(User user) {

            var isExist = _db.User.Find(user.Id);
            if (isExist != null)
            {
                isExist.Age = user.Age;
                isExist.City = user.City;
                isExist.Country = user.Country;
                isExist.Gender = user.Gender;
                isExist.Interests = user.Interests;
                isExist.Introduction = user.Introduction;
                isExist.KnownAs = user.KnownAs;
                isExist.LastActive = DateTime.Now;
                isExist.LookingFor = user.LookingFor;
                isExist.Name = user.Name;
                _db.Update(isExist);
                _db.SaveChanges();
            }      
        }
        public bool IsExist(int userId)
        {
            return _db.User.Find(userId)==null ? false: true;
        }

        
    }
}
