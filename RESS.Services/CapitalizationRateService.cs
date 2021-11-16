using RESS.Data;
using RESS.Models.CapitalizationRate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class CapitalizationRateService : ICapitalizationRateService
    {

        



        public bool CreateCapitalizationRate(CapitalizationRateCreate model)
        {
            var entity =
                new CapitalizationRateAnalysis()
                {
                    CapRateRunDate = DateTime.UtcNow,
                    PropertyId = model.PropertyId,
                    OwnerId = model.OwnerId,
                    PropAddress = model.PropAddress,

                    RentalIncome = model.RentalIncome,
                    MonthlyLaundryIncome = model.MonthlyLaundryIncome,
                    MonthlyMiscIncome = model.MonthlyMiscIncome,
                    TotalMonthlyIncome = model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome,

                    MonthlyMortgageExpense = model.MonthlyMortgageExpense,
                    MonthlyRentalInsuranceExpense = model.MonthlyRentalInsuranceExpense,
                    MonthlyUtilityExpense = model.MonthlyUtilityExpense,
                    MonthlyHoaExpense = model.MonthlyHoaExpense,
                    MonthlyPropertyServiceExpense = model.MonthlyPropertyServiceExpense,
                    MonthlyVacancyExpense = model.MonthlyVacancyExpense,
                    MonthlyRepairExpense = model.MonthlyRepairExpense,
                    MonthlyManagementExpense = model.MonthlyManagementExpense,
                    TotalMonthlyPropertyExpenses = model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense,

                    AnnualNetOperatingIncome = ((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12,
                    AnnualRentIncreasePercent = model.AnnualRentIncreasePercent,
                    PropMarketValue = model.PropMarketValue,
                    PropPurchasePrice = (decimal)model.PropPurchasePrice,
                    PropOwnedDuration = model.PropOwnedDuration,

                    CurrentCapitalizationRate = (float)((((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12) / model.PropPurchasePrice),
                    EstFiveYearCapitalizationRate = (float)((((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12) / (decimal)(model.PropPurchasePrice) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 5))),
                    EstFifteenYearCapitalizationRate = (float)((((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12) / (decimal)(model.PropPurchasePrice) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 15))),
                    EstThirtyYearCapitalizationRate = (float)((((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12) / (decimal)(model.PropPurchasePrice) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, 30))),
                    OwnedDurationCapitalizationRate = (float)((((model.MonthlyLaundryIncome + model.MonthlyMiscIncome + model.RentalIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyVacancyExpense + model.MonthlyRepairExpense + model.MonthlyManagementExpense)) * 12) / (decimal)(model.PropPurchasePrice) * (decimal)(1 + Math.Pow(model.AnnualRentIncreasePercent, model.PropOwnedDuration.TotalDays)))

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.CapitalizationRateAnalyses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CapitalizationRateListItem> GetCapitalizationRate()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .CapitalizationRateAnalyses
                        .Select(
                            e =>
                                new CapitalizationRateListItem
                                {
                                    CapitalizationRateAnalysisId = e.CapitalizationRateAnalysisId,
                                    CapRateRunDate = e.CapRateRunDate,
                                    PropAddress = e.Properties.Address,
                                    PropertyId = e.Properties.PropertyId,
                                    OwnerId = e.Owners.OwnerId

                                });
                return query.ToArray().OrderByDescending(e => e.CapRateRunDate);
            }
        }

        public CapitalizationRateDetail GetCapitalizationRateById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CapitalizationRateAnalyses
                        .Single(e => e.CapitalizationRateAnalysisId == id);
                return
                    new CapitalizationRateDetail
                    {
                        CapitalizationRateAnalysisId = entity.CapitalizationRateAnalysisId,
                        CapRateRunDate = entity.CapRateRunDate,
                        PropertyId = entity.PropertyId,
                        PropAddress = entity.PropAddress,
                        OwnerId = entity.OwnerId,

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
                        PropMarketValue = entity.PropMarketValue,
                        PropPurchasePrice = entity.PropPurchasePrice,
                        PropOwnedDuration = entity.PropOwnedDuration,

                        CurrentCapitalizationRate = entity.CurrentCapitalizationRate,
                        EstFiveYearCapitalizationRate = entity.EstFiveYearCapitalizationRate,
                        EstFifteenYearCapitalizationRate = entity.EstFifteenYearCapitalizationRate,
                        EstThirtyYearCapitalizationRate = entity.EstThirtyYearCapitalizationRate,
                        OwnedDurationCapitalizationRate = entity.OwnedDurationCapitalizationRate


                    };
            }
        }

        /*public bool UpdateCapitalizationRate(CapitalizationRateEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Tenants
                        .Single(e => e.TenantId == model.TenantId);

                

                return ctx.SaveChanges() == 1;

            }
        }*/

        public bool DeleteCapitalizationRate(int capitalizationRateAnalysisId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .CapitalizationRateAnalyses
                    .Single(e => e.CapitalizationRateAnalysisId == capitalizationRateAnalysisId);
                ctx.CapitalizationRateAnalyses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
