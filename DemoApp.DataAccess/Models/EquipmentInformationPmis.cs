using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class EquipmentInformationPmis
    {
        public long EquipmentInformationPmiId { get; set; }
        public long? LocationId { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentSerial { get; set; }
        public string Floor { get; set; }
        public string Enclosure { get; set; }
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
