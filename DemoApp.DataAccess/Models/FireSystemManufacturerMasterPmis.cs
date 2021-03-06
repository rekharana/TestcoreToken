﻿using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class FireSystemManufacturerMasterPmis
    {
        public int Id { get; set; }
        public string Fsmanufacturer { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
