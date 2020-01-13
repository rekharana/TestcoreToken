using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class Pmichecklists
    {
        public long Id { get; set; }
        public int? PmitypeId { get; set; }
        public long? PmiId { get; set; }
        public int? CategoryTypeId { get; set; }
        public long? QuestionId { get; set; }
        public int? StatusTypeId { get; set; }
        public string Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsArchived { get; set; }

        public virtual PmitypeMasters Pmitype { get; set; }
    }
}
