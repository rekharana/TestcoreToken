using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmichecklistHistoryLogs
    {
        public int Id { get; set; }
        public int? PmitypeId { get; set; }
        public long? PmiId { get; set; }
        public int? CategoryTypeId { get; set; }
        public string CategoryType { get; set; }
        public string Question { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchived { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
