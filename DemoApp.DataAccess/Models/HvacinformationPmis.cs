using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class HvacinformationPmis
    {
        public long HvacId { get; set; }
        public long? LocationId { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentCode { get; set; }
        public string UnitManufacture { get; set; }
        public string UnitModel { get; set; }
        public string UnitSerial { get; set; }
        public string UnitKwrating { get; set; }
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
