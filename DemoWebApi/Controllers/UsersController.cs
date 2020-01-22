using DemoApp.Service;
using DemoWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoWebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    // [Authorize]
    [Route("api/[controller]")]
    //[Route("api/users")]
    public class UsersController : Controller
    {
        private IUserMasterService _userService;
        private readonly IHostingEnvironment _hostingEnv;
        private const string ChampionsImageFolder = "http://localhost:49548/";
      
        public UsersController(IUserMasterService userService, IHostingEnvironment hostingEnv)
        {
            _userService = userService;
            _hostingEnv = hostingEnv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //  string path = GetImage();
            //List<user1> user1 = new List<user1>();
            //user1.Add(new user1() { id = 1, age = 24, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rekha", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_2.jfif", Photos = null });
            //user1.Add(new user1() { id = 2, age = 24, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "chand", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_3.jfif", Photos = null });
            //user1.Add(new user1() { id = 3, age = 26, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rana", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_4.jfif", Photos = null });
            //user1.Add(new user1() { id = 4, age = 28, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "Nangal", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder +  "/Image_5.jfif", Photos = null });
            //user1.Add(new user1() { id = 5, age = 29, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Maya", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder +  "/Image_2.jfif", Photos = null });
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _userService.GetUserById(id);
            if(data is null)
            {
                return BadRequest(new { massege = "Not record found" });
            }
            List<PhotoDTO> photodto = new List<PhotoDTO>();
            if (data.Photo.Count() > 0) {
                
                foreach (var item in data.Photo)
                {
                    photodto.Add(new PhotoDTO() { Url = ChampionsImageFolder + item.Url, DateAdded = item.DateAdded.Value, Description = item.Description, Id = item.Id, IsMain = item.IsMain.Value});                  
                }
               
            }
            var userDTO = new UserDTO() {
                Username = data.Username,
                Age = data.Age,
                City = data.City,
                Country = data.Country,
                Created = data.Created,
                Gender = data.Gender,
                Id = data.Id,
                Interests = data.Interests,
                Introduction = data.Introduction,
                KnownAs = data.KnownAs,
                LastActive = data.LastActive,
                LookingFor = data.LookingFor,
                Name = data.Name,
                TokenId = data.TokenId,
                PhotoUrl = data.Photo!=null? ChampionsImageFolder + data.Photo.FirstOrDefault().Url:null,
                Photos = photodto
            };
            return  Ok(userDTO);
        }
               

        ////// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string model)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]DemoApp.DataAccess.Models.User user1)
        {
            try
            {
                if (!_userService.IsExist(id))
                    return BadRequest(new { message = "User not found" });

                _userService.Update(user1);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = ex.InnerException });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]

        public async Task<IActionResult> Post([FromBody]AuthenticateModel model)
        {

            var user =await  _userService.Login(model.Username, model.Password);
            bool islogin = user != null ? true : false;
          
            //var user1 = _userService.Authenticate(model.Username, model.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            //HttpContext.Session.SetString("JWToken", user.Token);
            return Ok(new { token = user.TokenId });
        }

        // PUT api/values/5
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]User user)
        {
            try
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);
                if (await isUserExists(user.Username))
                {
                    return BadRequest("Username already exist");
                }
                _userService.Register(user.Username, passwordHash, passwordSalt);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }



        public async Task<bool> isUserExists(string username)
        {
            return await _userService.UserExist(username);
        }
        [HttpPost("login")]
        public async Task<bool> Login([FromBody]AuthenticateModel model)
        {
            var user = await _userService.Login(model.Username, model.Password);
            bool islogin = user != null ? true : false;
            return islogin;
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            }
        }

        public string GetImage()
        {
            var path = Path.Combine(_hostingEnv.WebRootPath, ChampionsImageFolder);

            return path;
        }

    }
}