using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmitypeMasters
    {
        public PmitypeMasters()
        {
            PmicategoryTypeMasters = new HashSet<PmicategoryTypeMasters>();
            PmichecklistQuestionMasters = new HashSet<PmichecklistQuestionMasters>();
            Pmichecklists = new HashSet<Pmichecklists>();
        }

        public int Id { get; set; }
        public string Pmitype { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }
        public int? PmimasterId { get; set; }

        public virtual ICollection<PmicategoryTypeMasters> PmicategoryTypeMasters { get; set; }
        public virtual ICollection<PmichecklistQuestionMasters> PmichecklistQuestionMasters { get; set; }
        public virtual ICollection<Pmichecklists> Pmichecklists { get; set; }
    }
}
