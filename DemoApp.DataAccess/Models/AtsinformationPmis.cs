using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class AtsinformationPmis
    {
        public long AtsinformationPmiId { get; set; }
        public long? LocationId { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentCode { get; set; }
        public string Atsmake { get; set; }
        public string Atsmodel { get; set; }
        public string Atsserial { get; set; }
        public DateTime? InstalledDate { get; set; }
        public bool? IsCompleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
        public int? PmitypeId { get; set; }
    }
}
