using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwtaskScheduleTaskDetails
    {
        public long TaskScheduleId { get; set; }
        public long? ParentTaskScheduleId { get; set; }
        public long? JobId { get; set; }
        public long? CircuitId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Term { get; set; }
        public int? MinimumTerm { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? PplannedInstallDate { get; set; }
        public DateTime? PactualInstallDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool? IsOpen { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsActive { get; set; }
        public int WorkFlowTaskId { get; set; }
        public int? DepartmentId { get; set; }
        public int? WorkFlowTypeId { get; set; }
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int? DeptGroupId { get; set; }
        public string TrackingTaskName { get; set; }
        public string WebPage { get; set; }
        public string JobNumber { get; set; }
        public int? PtpcircuitId { get; set; }
        public int? CustomerDesiredDate { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsPermitsTask { get; set; }
        public bool? IsImplementationTask { get; set; }
        public int ServiceTypeId { get; set; }
        public bool? IsNa { get; set; }
        public int? CompletedBy { get; set; }
        public bool? IsJobLevel { get; set; }
        public int? WorkFlowTaskStatusId { get; set; }
        public bool? IsNew { get; set; }
        public string Description { get; set; }
        public bool? IsMailDue { get; set; }
        public bool? IsNotificationDue { get; set; }
        public bool? IsProgress { get; set; }
        public bool? IsNotificationProgress { get; set; }
        public string MailGuid { get; set; }
        public bool? IsEarlyComplete { get; set; }
        public bool? IsDropCable { get; set; }
        public bool? IsMou { get; set; }
        public int IsHold { get; set; }
        public int? CircuitGroupId { get; set; }
        public int? CircuitIsParent { get; set; }
        public bool? IsGroupable { get; set; }
        public int? IsJeopardy { get; set; }
        public string DepartmentName { get; set; }
        public int? Focdate { get; set; }
        public string TaskCode { get; set; }
        public int? CustomerTypeId { get; set; }
        public string DeptGroupName { get; set; }
        public long? SequenceId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public byte[] Timestamp { get; set; }
        public int? DepartmentGroupDetailId { get; set; }
        public int? ServiceItemMasterId { get; set; }
        public string ServiceItem { get; set; }
        public string ServiceType { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceLevelSdm { get; set; }
        public string ServicelevelSdmgroup { get; set; }
        public int? OrderCreatedBy { get; set; }
        public string TaskStage { get; set; }
        public string FullTaskCode { get; set; }
        public string OnHoldReason { get; set; }
        public bool? IsOnHold { get; set; }
        public int? OnHoldBy { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public DateTime? ResumeDate { get; set; }
        public int? WorkFlowId { get; set; }
    }
}
