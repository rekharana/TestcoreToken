using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmimasterTableInformations
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string TableName { get; set; }
        public string KeyColumn { get; set; }
        public string ValueColumn { get; set; }
        public bool IsAddAllowed { get; set; }
        public bool IsActiveAllowed { get; set; }
        public bool IsActive { get; set; }
    }
}
