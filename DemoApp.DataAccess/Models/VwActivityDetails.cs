using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwActivityDetails
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string TaskEmail { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string AssignedBy { get; set; }
        public string AssignedTo { get; set; }
        public string Attachments { get; set; }
        public int? EntityValue { get; set; }
        public int? EntityTypeId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? Isactive { get; set; }
        public int? TaskStatusId { get; set; }
        public int? AssignToUserId { get; set; }
        public int? CreatedBy { get; set; }
        public string EntityValueName { get; set; }
        public int? StageTypeId { get; set; }
        public long? RelatedToEntityValue { get; set; }
    }
}
