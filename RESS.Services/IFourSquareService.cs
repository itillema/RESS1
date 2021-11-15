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
<<<<<<< HEAD
        IEnumerable<FourSquareAnalysis> MostRecentFourSquareAnalysis();
=======
>>>>>>> c5f3994 (updated remote path)
        bool UpdateFourSquare(FourSquareEdit model);
    }
}