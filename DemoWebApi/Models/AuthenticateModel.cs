namespace DemoWebApi.Models
{
    public class AuthenticateModel
    {

        public string Username { get; set; }

        public string Password { get; set; }
    }


    public class UserMasterVM
    {


        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; } 

    }
    public  class User
    {
        public int Id { get; set; }
        public string  Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Password { get; set; }

    }
}
