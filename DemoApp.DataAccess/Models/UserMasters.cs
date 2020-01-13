using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class UserMasters
    {
        public UserMasters()
        {
            Customers = new HashSet<Customers>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAcceptedTermsConditions { get; set; }
        public int? UserTypeId { get; set; }
        public string Ttsrole { get; set; }
        public string Moprole { get; set; }
        public int? CmsroleId { get; set; }
        public bool? IsCpaccessAllowed { get; set; }
        public bool? IsCiaccessAllowed { get; set; }
        public int? DepartmentId { get; set; }
        public bool? ShouldNotified { get; set; }
        public string MobileNumber { get; set; }
        public int? ContactTypeId { get; set; }
        public int? TtsuserGroupId { get; set; }
        public string TokenId { get; set; }
        public DateTime? TokenCreatedOn { get; set; }
        public int? LocationId { get; set; }
        public int? OfficeId { get; set; }
        public int? DesignationId { get; set; }
        public string ImageUrl { get; set; }
        public int? ReportTo { get; set; }
        public DateTime? LastOssloginTime { get; set; }
        public DateTime? LastCrmloginTime { get; set; }
        public DateTime? LastTtsloginTime { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
