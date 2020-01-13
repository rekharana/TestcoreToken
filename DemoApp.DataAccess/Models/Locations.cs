using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public int? LocTypeId { get; set; }
        public int StreetId { get; set; }
        public int? OffNetFootageId { get; set; }
        public string LocationName { get; set; }
        public string Demarc { get; set; }
        public bool? IsLocDiverseEntry { get; set; }
        public string LocNote { get; set; }
        public int? Ubid { get; set; }
        public string ClliCode { get; set; }
        public bool? NotInBuilding { get; set; }
        public int? Handoff { get; set; }
        public int? BuildingFiberStatusId { get; set; }
        public int? BuildingServiceStatusId { get; set; }
        public int? ThirdPartyBuildingStatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool IsActive { get; set; }
        public string Cllicode1 { get; set; }
        public string Lata { get; set; }
        public string Ftpdemarc { get; set; }
        public string OspdemarcNotes { get; set; }
        public string IspdemarcNotes { get; set; }
        public int? UpnhubStatusId { get; set; }
        public int? LocationRecordId { get; set; }
        public long? ParentLocationId { get; set; }
        public string BuildingSubTypeIds { get; set; }
        public bool? IsClliCodeUpdate { get; set; }

        public virtual StreetMasters Street { get; set; }
    }
}
