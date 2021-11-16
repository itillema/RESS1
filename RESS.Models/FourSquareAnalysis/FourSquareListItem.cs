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
        [Display(Name = "Ran on")]
        public DateTime FourSquareDateRan { get; set; }

        [Display(Name = "Property Address")]
        public string PropAddress { get; set; }

        
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }

        



        
    }
}
