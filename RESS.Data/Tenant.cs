using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Data
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime LeaseStart { get; set; }
        public DateTime LeaseEnd { get; set; }
        public TimeSpan LeaseDuration { get; set; }
        public decimal SecurityDeposit { get; set; }
        public decimal RentAmount { get; set; }

        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }
    }
}
