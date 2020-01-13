using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class LetterTypes
    {
        public LetterTypes()
        {
            LetterTemplates = new HashSet<LetterTemplates>();
        }

        public int LetterTypeId { get; set; }
        public string Description { get; set; }
        public string Template { get; set; }
        public bool? IsNotification { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPmi { get; set; }

        public virtual ICollection<LetterTemplates> LetterTemplates { get; set; }
    }
}
