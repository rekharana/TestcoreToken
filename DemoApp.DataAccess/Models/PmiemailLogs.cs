using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmiemailLogs
    {
        public long LogId { get; set; }
        public int? EmailTemplateId { get; set; }
        public string RenderedSubject { get; set; }
        public string RenderedBody { get; set; }
        public string RenderedTo { get; set; }
        public string RenderedCc { get; set; }
        public string RenderedBcc { get; set; }
        public long? TypeId { get; set; }
        public int? Type { get; set; }
        public DateTime? SentTime { get; set; }
    }
}
