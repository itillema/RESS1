using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.Owner
{
    public class OwnerEdit
    {
        public int OwnerId { get; set; }
        [Required]
        [Display(Name = "Owner First Name")]
        public string OwnerFirstName { get; set; }
        [Required]
        [Display(Name = "Owner Last Name")]
        public string OwnerLastName { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
        public string Email { get; set; }
        [Display(Name = "Property Purchase Date")]
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [Display(Name = "Down Payment")]
        public decimal DownPayment { get; set; }
        [Display(Name = "Initial Mortgage Amount")]
        public decimal MortgageAmount { get; set; }
        [Display(Name = "Properties for this Owner")]
        public List<Property> OwnedProperties { get; set; }

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }
    }
}
