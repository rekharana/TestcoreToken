using DemoApp.Service;
using DemoWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public UsersController(IUserMasterService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
            }catch(Exception ex)
            {
                return BadRequest("Error: "+ ex.Message);
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

    }
}