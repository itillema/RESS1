using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Data
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime PurchaseDate { get; set; }
        public TimeSpan OwnedDuration { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal DownPayment { get; set; }
        public decimal MortgageAmount { get; set; }
        public List<Property> OwnedProperties { get; set; }

        [ForeignKey(nameof(Property))]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }
    }
}
