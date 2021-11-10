using RESS.Data;
using RESS.Models.NetOperatingIncome;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface INetOperatingIncomeService
    {
        bool CreateNetOperatingIncome(NetOperatingIncomeCreate model);
        bool DeleteNetOperatingIncome(int netOperatingIncomeId);
        IEnumerable<NetOperatingIncomeListItem> GetNetOperatingIncome();
        NetOperatingIncomeDetail GetNetOperatingIncomeById(int id);
        IEnumerable<NetOperatingIncome> MostNetOperatingIncomeAnalysis();
        bool UpdateNetOperatingIncome(NetOperatingIncomeEdit model);
    }
}