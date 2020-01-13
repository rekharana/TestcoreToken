using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmicategoryTypeMasters
    {
        public PmicategoryTypeMasters()
        {
            PmichecklistQuestionMasters = new HashSet<PmichecklistQuestionMasters>();
        }

        public int Id { get; set; }
        public string CategoryType { get; set; }
        public int PmitypeId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchived { get; set; }
        public int? PmimasterId { get; set; }

        public virtual PmitypeMasters Pmitype { get; set; }
        public virtual ICollection<PmichecklistQuestionMasters> PmichecklistQuestionMasters { get; set; }
    }
}
