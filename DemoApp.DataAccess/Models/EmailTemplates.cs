using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class EmailTemplates
    {
        public int EmailTemplateId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int? TaskId { get; set; }
        public bool? IsEmail { get; set; }
        public bool? IsNotification { get; set; }
        public bool? IsActive { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsSilent { get; set; }
        public int? AssociatedDocumentType { get; set; }
    }
}
