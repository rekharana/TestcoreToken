using DemoApp.Service;
using DemoWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private const string ChampionsImageFolder = "http://localhost:49548/images";
      
        public UsersController(IUserMasterService userService, IHostingEnvironment hostingEnv)
        {
            _userService = userService;
            _hostingEnv = hostingEnv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //  string path = GetImage();
            List<user1> user1 = new List<user1>();
            user1.Add(new user1() { id = 1, age = 24, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rekha", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_2.jfif", Photos = null });
            user1.Add(new user1() { id = 2, age = 24, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "chand", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_3.jfif", Photos = null });
            user1.Add(new user1() { id = 3, age = 26, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rana", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_4.jfif", Photos = null });
            user1.Add(new user1() { id = 4, age = 28, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "Nangal", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder +  "/Image_5.jfif", Photos = null });
            user1.Add(new user1() { id = 5, age = 29, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Maya", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder +  "/Image_2.jfif", Photos = null });
            return Ok(user1);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public user1 Get(int id)
        {
            List<user1> user1 = new List<user1>();
            user1.Add(new user1() { id = 1, age = 24, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rekha", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_2.jfif", Photos = null });
            user1.Add(new user1() { id = 2, age = 24, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "chand", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_3.jfif", Photos = null });
            user1.Add(new user1() { id = 3, age = 26, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Rana", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_4.jfif", Photos = null });
            user1.Add(new user1() { id = 4, age = 28, gender = "Female", created = DateTime.Now, country = "India", knownAs = "KnownAs", city = "Nangal", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_5.jfif", Photos = null });
            user1.Add(new user1() { id = 5, age = 29, gender = "Male", created = DateTime.Now, country = "India", knownAs = "Maya", city = "City", interests = "Yes", introduction = "yo", lastActive = DateTime.Now, lookingFor = "You", name = "one", photoUrl = ChampionsImageFolder + "/Image_2.jfif", Photos = null });
                    
            return user1.Where(x=>x.id==id).SingleOrDefault();           
        }

        ////// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string model)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]

        public IActionResult Post([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);
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