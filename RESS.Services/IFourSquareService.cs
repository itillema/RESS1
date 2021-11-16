using RESS.Data;
using RESS.Models.FourSquareAnalysis;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface IFourSquareService
    {
        bool CreateFourSquare(FourSquareCreate model);
        bool DeleteFourSquare(int fourSquareId);
        IEnumerable<FourSquareListItem> GetFourSquare();
        FourSquareDetail GetFourSquareById(int id);


        
    }
}