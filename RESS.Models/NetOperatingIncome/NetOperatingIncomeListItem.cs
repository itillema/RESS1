using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.NetOperatingIncome
{
    public class NetOperatingIncomeListItem
    {
        [Display(Name ="NOI Analysis ID")]
        public int NetOperatingIncomeId { get; set; }
        [Display(Name = "Ran on")]
        public DateTime NOIRundate { get; set; }
<<<<<<< HEAD
=======
        [Display(Name = "Property Address")]
        public string PropAddress { get; set; }
>>>>>>> c5f3994 (updated remote path)

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
<<<<<<< HEAD
        public string Address { get; set; }
=======
       
>>>>>>> c5f3994 (updated remote path)
        public virtual Property Property { get; set; }

        
    }
}
