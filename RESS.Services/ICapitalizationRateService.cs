using RESS.Data;
using RESS.Models.CapitalizationRate;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface ICapitalizationRateService
    {
        bool CreateCapitalizationRate(CapitalizationRateCreate model);
        bool DeleteCapitalizationRate(int capitalizationRateAnalysisId);
        IEnumerable<CapitalizationRateListItem> GetCapitalizationRate();
        CapitalizationRateDetail GetCapitalizationRateById(int id);
        
    }
}