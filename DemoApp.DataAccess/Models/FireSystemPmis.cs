using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class FireSystemPmis
    {
        public long FireSystemPmiId { get; set; }
        public long? LocationId { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentCode { get; set; }
        public int? FsmanufacturerId { get; set; }
        public string Fstype { get; set; }
        public string Fsserial { get; set; }
        public DateTime? InstalledDate { get; set; }
        public bool? IsCompleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
        public int? Pmitype { get; set; }
    }
}
