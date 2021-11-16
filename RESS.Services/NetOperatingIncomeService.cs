using RESS.Data;
using RESS.Models.NetOperatingIncome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class NetOperatingIncomeService : INetOperatingIncomeService
    {

        public IEnumerable<NetOperatingIncome> MostNetOperatingIncomeAnalysis()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.NetOperatingIncomeAnalyses.Include("Property").OrderByDescending(a => a.NOIRundate);
                return query.ToArray();
            }
        }

        public bool CreateNetOperatingIncome(NetOperatingIncomeCreate model)
        {
            var entity =
                new NetOperatingIncome()
                {
                    NOIRundate = DateTime.UtcNow,

                    PropertyId = model.PropertyId,
                    PropAddress = model.PropAddress,

                    RentalIncome = model.RentalIncome,
                    MonthlyLaundryIncome = model.MonthlyLaundryIncome,
                    MonthlyMiscIncome = model.MonthlyMiscIncome,
                    TotalMonthlyIncome = model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome,


                    MonthlyMortgageExpense = model.MonthlyMortgageExpense,
                    MonthlyRentalInsuranceExpense = model.MonthlyRentalInsuranceExpense,
                    MonthlyUtilityExpense = model.MonthlyUtilityExpense,
                    MonthlyHoaExpense = model.MonthlyHoaExpense,
                    MonthlyPropertyServiceExpense = model.MonthlyPropertyServiceExpense,
                    MonthlyVacancyExpense = model.MonthlyVacancyExpense,
                    MonthlyRepairExpense = model.MonthlyRepairExpense,
                    MonthlyManagementExpense = model.MonthlyManagementExpense,
                    TotalMonthlyPropertyExpenses = model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyPropertyServiceExpense + model.MonthlyHoaExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense,


                    AnnualNetOperatingIncome = (model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyPropertyServiceExpense + model.MonthlyHoaExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense),
                    AnnualRentIncreasePercent = model.AnnualRentIncreasePercent,

                    FiveYearNoi = ((model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyPropertyServiceExpense + model.MonthlyHoaExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 5)),
                    FifteenYearNoi = ((model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyPropertyServiceExpense + model.MonthlyHoaExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 15)),
                    ThirtyYearNoi = ((model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyPropertyServiceExpense + model.MonthlyHoaExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 30))


                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.NetOperatingIncomeAnalyses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NetOperatingIncomeListItem> GetNetOperatingIncome()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NetOperatingIncomeAnalyses
                        .Select(
                            e =>
                                new NetOperatingIncomeListItem
                                {
                                    NetOperatingIncomeId = e.NetOperatingIncomeId,
                                    NOIRundate = e.NOIRundate,
                                    PropertyId = e.PropertyId,

                                    PropAddress = e.PropAddress,



                                });
                return query.ToArray().OrderByDescending(e => e.NOIRundate);
            }
        }

        public NetOperatingIncomeDetail GetNetOperatingIncomeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NetOperatingIncomeAnalyses
                        .Single(e => e.NetOperatingIncomeId == id);
                return
                    new NetOperatingIncomeDetail
                    {
                        NetOperatingIncomeId = entity.NetOperatingIncomeId,
                        NOIRundate = entity.NOIRundate,
                        PropertyId = entity.PropertyId,

                        PropAddress = entity.PropAddress,

                        RentalIncome = entity.RentalIncome,

                        MonthlyLaundryIncome = entity.MonthlyLaundryIncome,
                        MonthlyMiscIncome = entity.MonthlyMiscIncome,
                        TotalMonthlyIncome = entity.TotalMonthlyIncome,

                        MonthlyMortgageExpense = entity.MonthlyMortgageExpense,
                        MonthlyRentalInsuranceExpense = entity.MonthlyRentalInsuranceExpense,
                        MonthlyUtilityExpense = entity.MonthlyUtilityExpense,
                        MonthlyHoaExpense = entity.MonthlyHoaExpense,
                        MonthlyPropertyServiceExpense = entity.MonthlyPropertyServiceExpense,
                        MonthlyVacancyExpense = entity.MonthlyVacancyExpense,
                        MonthlyRepairExpense = entity.MonthlyRepairExpense,
                        MonthlyManagementExpense = entity.MonthlyManagementExpense,
                        TotalMonthlyPropertyExpenses = entity.TotalMonthlyPropertyExpenses,

                        AnnualNetOperatingIncome = entity.AnnualNetOperatingIncome,
                        AnnualRentIncreasePercent = entity.AnnualRentIncreasePercent,

                        FiveYearNoi = entity.FiveYearNoi,
                        FifteenYearNoi = entity.FifteenYearNoi,
                        ThirtyYearNoi = entity.ThirtyYearNoi

                    };
            }
        }

        public bool UpdateNetOperatingIncome(NetOperatingIncomeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NetOperatingIncomeAnalyses
                        .Single(e => e.NetOperatingIncomeId == model.NetOperatingIncomeId);

                /*entity.TenantFirstName = model.TenantFirstName;
                entity.TenantLastName = model.TenantLastName;
                entity.MobileNo = model.MobileNo;
                entity.LeaseStart = model.LeaseStart;
                entity.LeaseEnd = model.LeaseEnd;
                entity.SecurityDeposit = model.SecurityDeposit;
                entity.RentAmount = model.RentAmount;*/

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteNetOperatingIncome(int netOperatingIncomeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .NetOperatingIncomeAnalyses
                    .Single(e => e.NetOperatingIncomeId == netOperatingIncomeId);
                ctx.NetOperatingIncomeAnalyses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
