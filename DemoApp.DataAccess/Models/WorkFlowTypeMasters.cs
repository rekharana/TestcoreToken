using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class WorkFlowTypeMasters
    {
        public int WorkFlowTypeId { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool IsActivityType { get; set; }
    }
}
