using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class PmichecklistStatusMasters
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchived { get; set; }
    }
}
