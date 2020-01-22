using DemoApp.DataAccess.Models;
using DemoApp.Service.IService;
using DemoWebApi.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Service.Services
{
  public  class PhotoService : IPhotoService
    {
        private readonly AppSettings _appSettings;
        private readonly PMIContext _db;
        public PhotoService(IOptions<AppSettings> appSettings, PMIContext db)
        {
            _appSettings = appSettings.Value;
            _db = db;
        }
        public Photo SaveAll(Photo photo) {           
                if (_db.Photo.Any(x => x.IsMain.Value))
                    photo.IsMain = true;

                _db.Photo.Add(photo);
                _db.SaveChanges();
            
                return photo;           
        }

        public async Task<Photo> GetPhoto(int id) {
            var photo = _db.Photo.FirstOrDefault(x => x.Id == id);
            return photo;
        }
    }
}
