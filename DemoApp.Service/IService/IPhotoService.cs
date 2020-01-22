using DemoApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Service.IService
{
   public interface IPhotoService
    {
        Photo SaveAll(Photo photo);
        Task<Photo> GetPhoto(int id);
    }
}
