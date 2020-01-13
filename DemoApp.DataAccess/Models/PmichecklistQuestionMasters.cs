using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmichecklistQuestionMasters
    {
        public int Id { get; set; }
        public int PmitypeId { get; set; }
        public string Question { get; set; }
        public string CategoryType { get; set; }
        public int? CategoryTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }

        public virtual PmicategoryTypeMasters CategoryTypeNavigation { get; set; }
        public virtual PmitypeMasters Pmitype { get; set; }
    }
}
