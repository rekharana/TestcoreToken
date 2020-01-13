using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwWorkflowNotificationDetail
    {
        public string OppotunityOwner { get; set; }
        public string TrackerNumber { get; set; }
        public string OpportunityName { get; set; }
        public DateTime? CloseDate { get; set; }
        public string AccountName { get; set; }
        public string OpportunityType { get; set; }
        public string CoreMarket { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string NetworkScope { get; set; }
        public DateTime? LogicalDrawingComplete { get; set; }
        public string OptionName { get; set; }
        public string TypeIicolo { get; set; }
        public long? JobOptionId { get; set; }
        public long? EstimationRequestId { get; set; }
        public string RegionName { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string RequestNumber { get; set; }
        public string WorkflowInstanceStatus { get; set; }
        public long ParentJobId { get; set; }
        public long? JobId { get; set; }
        public bool? IsCancelled { get; set; }
        public string CancelReason { get; set; }
        public string VerticalMarket { get; set; }
        public long CrmJobOptionId { get; set; }
        public string OptionRegionName { get; set; }
        public string EstimationNotes { get; set; }
    }
}
