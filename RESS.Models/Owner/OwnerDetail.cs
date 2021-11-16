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
    public class OwnerDetail
    {
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        [Display(Name = "Owner First Name")]
        public string OwnerFirstName { get; set; }
        [Display(Name = "Owner Last Name")]
        public string OwnerLastName { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        //[Display(Name = "Property Purchase Date")]
        //public DateTime PurchaseDate { get; set; }
        //[Display(Name = "Duration Owned Property")]
        //public TimeSpan OwnedDuration { get; set; }
        //[Display(Name = "Purchase Price")]
        //public decimal PurchasePrice { get; set; }
        //[Display(Name = "Down Payment")]
        //public decimal DownPayment { get; set; }
        //[Display(Name = "Initial Mortgage Amount")]
        //public decimal MortgageAmount { get; set; }

        //[Display(Name = "Properties for this Owner")]
        //public virtual ICollection<Property> OwnedProperties { get; set; }

    }
}
