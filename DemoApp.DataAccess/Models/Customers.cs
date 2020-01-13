using System;
using System.Collections.Generic;

namespace DemoApp.DataAccess.Models
{
    public partial class Customers
    {
        public Customers()
        {
            InverseParentCustomer = new HashSet<Customers>();
        }

        public int CustomerId { get; set; }
        public int? CustomerOwnerUserId { get; set; }
        public int? ParentCustomerId { get; set; }
        public int? PrimaryCustomerId { get; set; }
        public int? CustomerTypeId { get; set; }
        public int? IndustryTypeId { get; set; }
        public string DisplayId { get; set; }
        public int CustomerStatusId { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public string SubAccountNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string EmaiId { get; set; }
        public bool? ContactCustomer { get; set; }
        public bool? IsPriorityCustomer { get; set; }
        public bool? IsTtssurveyNeeded { get; set; }
        public string Satype { get; set; }
        public bool? IsSensitive { get; set; }
        public bool? IsGtcattached { get; set; }
        public string Website { get; set; }
        public int? Employees { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public string InvoiceSubmittalEmail { get; set; }
        public string Description { get; set; }
        public string AttentionTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsActive { get; set; }
        public string AgentFee { get; set; }
        public string Ben { get; set; }

        public virtual UserMasters CustomerOwnerUser { get; set; }
        public virtual Customers ParentCustomer { get; set; }
        public virtual ICollection<Customers> InverseParentCustomer { get; set; }
    }
}
