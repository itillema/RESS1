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
    public class OwnerListItem
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

    }
}
