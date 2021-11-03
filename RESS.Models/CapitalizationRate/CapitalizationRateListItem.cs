using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.CapitalizationRate
{
    public class CapitalizationRateListItem
    {
        // Analysis Identifiers
        [Display(Name ="Cap Rate ID")]
        public int CapitalizationRateAnalysisId { get; set; }
        [Display(Name = "Ran on")]
        public DateTime CapRateRunDate { get; set; }

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }

        [ForeignKey(nameof(Owner))]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        public virtual Data.Owner Owner { get; set; }
    }
}
