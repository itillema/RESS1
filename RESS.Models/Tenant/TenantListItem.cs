using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.Tenant
{
    public class TenantListItem
    {
        [Display(Name = "Tenant ID")]
        public int TenantId { get; set; }
        [Display(Name = "First Name")]
        public string TenantFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string TenantLastName { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNo { get; set; }
        public string Email { get; set; }


    }
}
