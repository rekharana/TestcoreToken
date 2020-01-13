using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class Pmihistories
    {
        public long Id { get; set; }
        public int? TypeId { get; set; }
        public string Type { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
