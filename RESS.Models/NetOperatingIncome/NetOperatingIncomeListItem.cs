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

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }

        
    }
}
