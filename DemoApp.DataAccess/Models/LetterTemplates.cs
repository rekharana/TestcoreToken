using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class LetterTemplates
    {
        public int LetterTemplateId { get; set; }
        public int? LetterTypeId { get; set; }
        public string DisplayName { get; set; }
        public string FileName { get; set; }
        public string Subject { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }

        public virtual LetterTypes LetterType { get; set; }
    }
}
