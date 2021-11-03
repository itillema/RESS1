using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.Tenant
{
    public class TenantCreate
    {
        [Required]
        [Display(Name = "First Name")]
        public string TenantFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string TenantLastName { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
        public string Email { get; set; }
        [Display(Name = "Lease Start Date")]
        public DateTime LeaseStart { get; set; }
        [Display(Name = "Lease End Date")]
        public DateTime LeaseEnd { get; set; }
        [Display(Name = "Security Deposit Amount")]
        public decimal SecurityDeposit { get; set; }
        [Display(Name = "Monthly Rent Amount")]
        public decimal RentAmount { get; set; }
    }
}
