using System;

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
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Password { get; set; }

    }

    public class user1
    {

        public int id { get; set; }
        public string name { get; set; }
        public string knownAs { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public DateTime created { get; set; }
        public DateTime lastActive { get; set; }
        public string photoUrl { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string interests { get; set; }
        public string introduction { get; set; }
        public string lookingFor { get; set; }
        public Photo Photos { get; set; }

    }
    public class Photo
    {
        public int id { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public DateTime dateAdded { get; set; }
        public bool isMain { get; set; }
    }
}
