using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwGetLocationListNew
    {
        public string LocationRecord { get; set; }
        public string Cllicode1 { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string StreetDescription { get; set; }
        public string City { get; set; }
        public string StateDescription { get; set; }
        public string Zip { get; set; }
        public string ClliCode { get; set; }
        public bool IsActive { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Floor { get; set; }
        public string Suite { get; set; }
        public string County { get; set; }
        public string BuildingType { get; set; }
        public string BuildingFiberStatus { get; set; }
        public string BuildingServiceStatus { get; set; }
        public string ThirdPartyBuildingStatus { get; set; }
        public int? VerificationStatus { get; set; }
        public int StreetId { get; set; }
        public int? BuildingTypeNew { get; set; }
        public string Lata { get; set; }
        public string AlternateAddress { get; set; }
        public string Ftpdemarc { get; set; }
        public string OspDermicNotes { get; set; }
        public string Cage { get; set; }
        public string Rack { get; set; }
        public string IspdemarcNotes { get; set; }
        public string StatusChangeNotes { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string Auditverification { get; set; }
        public DateTime? LastAuditDate { get; set; }
        public int? LastAuditedBy { get; set; }
        public string LastAuditByName { get; set; }
        public string LastModifiedBy { get; set; }
        public string SubBuildingType { get; set; }
        public string Market { get; set; }
        public string SubMarket { get; set; }
        public string UpnHubStatus { get; set; }
        public string LocationtypeNew { get; set; }
        public int? LocationTypeId { get; set; }
        public string BuildingServiceType { get; set; }
        public string ValidatationStatus { get; set; }
        public string LocStatus { get; set; }
        public string OpportnityAccountList { get; set; }
        public string OrderAccountList { get; set; }
        public string AssociatedProjects { get; set; }
    }
}
