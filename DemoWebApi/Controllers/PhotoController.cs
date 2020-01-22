using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DemoApp.DataAccess.Models;
using DemoApp.Service;
using DemoApp.Service.IService;
using DemoWebApi.Helper;
using DemoWebApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoWebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/users/{userId}/photo")]
    public class PhotoController : Controller
    {
        private readonly IOptions<CloudinarySetting> _cloudinarySetting;
        private readonly IUserMasterService _userMasterService;
        private readonly IPhotoService _photoService;
        private Cloudinary _cloudinary;
        public PhotoController(IOptions<CloudinarySetting> cloudinarySetting, IUserMasterService userMasterService, IPhotoService photoService)
        {
            _cloudinarySetting = cloudinarySetting;
            _userMasterService = userMasterService;
            _photoService = photoService;
            Account ac = new Account(
                _cloudinarySetting.Value.CloudName,
                _cloudinarySetting.Value.ApiKey,
                _cloudinarySetting.Value.ApiSecret);

            _cloudinary = new Cloudinary(ac);

        }
        [HttpPost]
        public async Task<IActionResult> Post(int userId, [FromForm]PhotoDTO Photo) {
          //  if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                if (userId != int.Parse("1"))
                return Unauthorized();

            var _user = _userMasterService.GetUserById(userId);
            if (_user is null)
                return NotFound();

            var file = PhotoDTO.File;
            var uploadResult = new ImageUploadResult();
            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File=new FileDescription(file.Name,stream),
                        Transformation= new Transformation().Width("500").Height("500").Crop("fill").Gravity("face")
                    };
                    uploadResult = _cloudinary.Upload(uploadParams);
                }
            }


            DemoApp.DataAccess.Models.Photo photo = new DemoApp.DataAccess.Models.Photo();
            photo.Url = uploadResult.Uri.ToString();
            photo.PublicId = uploadResult.PublicId.ToString();
        
            if(_photoService.SaveAll(photo)is null)
            return BadRequest("Could not add the photo");

            return CreatedAtRoute("GetPhoto", new { userId = userId, id = photo.Id }, Photo);
        }

        public async Task<IActionResult> GetPhoto(int id) {

            var photo = Task.Run(() => _photoService.GetPhoto(id));
            return Ok(photo);
        }
    }
}
