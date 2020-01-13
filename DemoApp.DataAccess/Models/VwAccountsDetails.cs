using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class VwAccountsDetails
    {
        public int CustomerId { get; set; }
        public string AccountOwner { get; set; }
        public string AccountId { get; set; }
        public string Accountname { get; set; }
        public string ParentAccount { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PrimaryAddress { get; set; }
        public string AccountStatus { get; set; }
        public string AccountType { get; set; }
        public int? AccountOwnerId { get; set; }
        public int? AccountTypeId { get; set; }
        public int? IndustryTypeId { get; set; }
        public bool IsActive { get; set; }
        public string CustomerJobs { get; set; }
        public string IndustryType { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string AgentFee { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public int? Employees { get; set; }
        public string Description { get; set; }
    }
}
