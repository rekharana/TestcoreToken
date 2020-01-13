using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwUserAuthenticate
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DepartmentIds { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string DepartmentNames { get; set; }
        public string RoleIds { get; set; }
        public string RoleNames { get; set; }
        public string DeptWisepermissions { get; set; }
        public string AllPermissions { get; set; }
        public string GroupIds { get; set; }
        public string GroupNames { get; set; }
        public int RoleId { get; set; }
        public bool IsAcceptedTermsConditions { get; set; }
        public int UserTypeid { get; set; }
        public int IsCpaccessAllowed { get; set; }
        public int IsCiaccessAllowed { get; set; }
        public string Ttsrole { get; set; }
        public string DepartmentMasterIds { get; set; }
        public string DepartmentMasterNames { get; set; }
        public string ImageUrl { get; set; }
    }
}
