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
<<<<<<< HEAD

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public virtual Property Property { get; set; }
=======
        [Display(Name = "Property Address")]
        public string PropAddress { get; set; }

        [ForeignKey(nameof(Properties))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }

        public virtual Property Properties { get; set; }
>>>>>>> c5f3994 (updated remote path)


        
    }
}
