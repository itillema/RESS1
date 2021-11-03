using RESS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.Portal
{
    public class DashboardViewModel
    {
        public IEnumerable<Data.CapitalizationRateAnalysis> MostRecentCapRateAnalyses { get; set; }
        public IEnumerable<Data.FourSquareAnalysis> MostRecentFourSqrAnalyses { get; set; }
        public IEnumerable<Data.NetOperatingIncome> MostRecentNOIAnalyses { get; set; }
    }
}
