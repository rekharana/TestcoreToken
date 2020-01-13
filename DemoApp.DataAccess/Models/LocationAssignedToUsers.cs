using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class LocationAssignedToUsers
    {
        public long LocationAssignedToUsersId { get; set; }
        public long? LocationId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
    }
}
