using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwCircuitDetailsList
    {
        public long? JobOptionId { get; set; }
        public long CircuitDetailId { get; set; }
        public string PtpcircuitId { get; set; }
        public string IsColoSpaceRequired { get; set; }
        public string IsTypeIirequired { get; set; }
        public string RequestedBandwidth { get; set; }
        public string DarkFibersNo { get; set; }
        public string LocationA { get; set; }
        public int IsLocAduplicate { get; set; }
        public string LocAduplicateData { get; set; }
        public string LocationZ { get; set; }
        public int IsLocZduplicate { get; set; }
        public string LocZduplicateData { get; set; }
        public string ExistingTracker { get; set; }
        public string UpdatedTracker { get; set; }
        public string OrderType { get; set; }
        public string ProductType { get; set; }
        public long? PrimaryCircuitId { get; set; }
        public string ChildProductType { get; set; }
        public int? TypeId { get; set; }
        public int LocAverificationStatus { get; set; }
        public int LocZverificationStatus { get; set; }
        public int? LocationAid { get; set; }
        public int? LocationZid { get; set; }
        public int LocAstreetId { get; set; }
        public int LocZstreetId { get; set; }
        public bool IsCircuitIdCreated { get; set; }
        public bool IsCircuitReInitiated { get; set; }
        public int UpdatedCircuitTypeId { get; set; }
        public int IsLocAsameForSelectedProduct { get; set; }
        public string LocAcllicode { get; set; }
        public string LocZcllicode { get; set; }
        public int? CircuitStatusId { get; set; }
        public string CircuitStatus { get; set; }
        public long? ParentCocircuitDetailId { get; set; }
        public string IsCrossConnect { get; set; }
    }
}
