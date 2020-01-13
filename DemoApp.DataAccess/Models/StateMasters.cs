using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class StateMasters
    {
        public StateMasters()
        {
            StreetMasters = new HashSet<StreetMasters>();
        }

        public int StateId { get; set; }
        public string Description { get; set; }
        public int? RegionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public bool? IsMarket { get; set; }

        public virtual ICollection<StreetMasters> StreetMasters { get; set; }
    }
}
