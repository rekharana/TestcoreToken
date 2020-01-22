
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Models
{
    public class PhotoDTO
    {
        public string Url { get; set; }

        public static IFormFile File { get; set; }
        public string Description { get; set; }

        public DateTime DateAdded { get; set; }
        public bool? IsMain { get; set; }
        public int Id { get; set; }
       public PhotoDTO() { DateAdded = DateTime.Now; }
    }

    public class UserDTO {

        public int Id { get; set; }
        public string Username { get; set; }     
        public int? Age { get; set; }
        public string Gender { get; set; }
        public DateTime? Created { get; set; }
        public string Country { get; set; }
        public string KnownAs { get; set; }
        public string City { get; set; }
        public string Interests { get; set; }
        public string Introduction { get; set; }
        public DateTime? LastActive { get; set; }
        public string LookingFor { get; set; }
        public string Name { get; set; }

        public List<PhotoDTO> Photos { get; set; }
      
        public string TokenId { get; set; }     
        public string PhotoUrl { get; set; }
    }
}
