using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class StreetMasters
    {
        public StreetMasters()
        {
            Locations = new HashSet<Locations>();
        }

        public int StreetId { get; set; }
        public int? MarketId { get; set; }
        public int? LocationTypeId { get; set; }
        public int? BuildingTypeId { get; set; }
        public string Description { get; set; }
        public string StAddress { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public string County { get; set; }
        public string Zip { get; set; }
        public string Floor { get; set; }
        public string Suite { get; set; }
        public bool? IsDiverseEntrance { get; set; }
        public string LocationNote { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool? ViewProdMgmt { get; set; }
        public bool? NotInBuilding { get; set; }
        public string Cllicode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public int? VerificationStatus { get; set; }
        public string AlternateAddress { get; set; }
        public string Cage { get; set; }
        public string Rack { get; set; }
        public int? Market { get; set; }
        public int? SubMarketId { get; set; }
        public int? LocationType { get; set; }
        public int? BuildingSubTypeId { get; set; }
        public int? BuildingServiceTypeId { get; set; }
        public string StatusChangeNotes { get; set; }
        public bool? AuditVerification { get; set; }
        public DateTime? LastAuditedDate { get; set; }
        public int? LastAuditedBy { get; set; }
        public int? ValidatationStatus { get; set; }

        public virtual StateMasters State { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
