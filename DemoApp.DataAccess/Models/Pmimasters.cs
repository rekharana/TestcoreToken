using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class Pmimasters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
    }
}
