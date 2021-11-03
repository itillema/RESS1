using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.FourSquareAnalysis
{

    public class FourSquareListItem
    {
        // Analysis Identifiers
        [Display(Name = "Four Square Analysis ID")]
        public int FourSquareAnalysisId { get; set; }
        public DateTime FourSquareDateRan { get; set; }

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }


        
    }
}
