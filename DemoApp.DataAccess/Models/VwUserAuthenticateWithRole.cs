using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwUserAuthenticateWithRole
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string RoleIds { get; set; }
        public string RoleNames { get; set; }
        public string DepartmentId { get; set; }
        public string DeptWisepermissions { get; set; }
        public int RoleId { get; set; }
        public int UserTypeid { get; set; }
        public string Ttsrole { get; set; }
        public string MyTeams { get; set; }
        public string MyVerticals { get; set; }
    }
}
