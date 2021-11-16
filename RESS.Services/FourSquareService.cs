using RESS.Data;
using RESS.Models.FourSquareAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class FourSquareService : IFourSquareService
    {


        

        public bool CreateFourSquare(FourSquareCreate model)
        {
            
            var entity =
                new FourSquareAnalysis()
                {
                    FourSquareDateRan = DateTime.UtcNow,
                    PropertyId = model.PropertyId,  //
                    PropAddress = model.PropAddress,  //
                    FourSquareAnalysisId = model.FourSquareAnalysisId,

                    RentalIncome = model.RentalIncome, //
                    MonthlyLaundryIncome = model.MonthlyLaundryIncome,
                    MonthlyMiscIncome = model.MonthlyMiscIncome,
                    TotalMonthlyIncome = model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome,

                    MonthlyMortgageExpense = model.MonthlyMortgageExpense,
                    MonthlyRentalInsuranceExpense = model.MonthlyRentalInsuranceExpense,
                    MonthlyTaxExpense = model.MonthlyTaxExpense,
                    MonthlyUtilityExpense = model.MonthlyUtilityExpense,
                    MonthlyHoaExpense = model.MonthlyHoaExpense,
                    MonthlyPropertyServiceExpense = model.MonthlyPropertyServiceExpense,
                    MonthlyRepairExpense = model.MonthlyRepairExpense,
                    MonthlyVacancyExpense = model.MonthlyVacancyExpense,
                    MonthlyManagementExpense = model.MonthlyManagementExpense,
                    TotalMonthlyPropertyExpenses = model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyTaxExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyRepairExpense + model.MonthlyVacancyExpense + model.MonthlyManagementExpense,

                    TotalMonthlyCashFlow = (model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyTaxExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyRepairExpense + model.MonthlyVacancyExpense + model.MonthlyManagementExpense),
                    EstDownPayment = model.EstDownPayment,
                    EstClosingCost = model.EstClosingCost,
                    EstRehabBudget = model.EstRehabBudget,
                    EstTotalInvestment = model.EstDownPayment + model.EstClosingCost + model.EstRehabBudget,
                    EstAnnaulCashFlow = ((model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyTaxExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyRepairExpense + model.MonthlyVacancyExpense + model.MonthlyManagementExpense)) * 12,
                    
                    TotalCtcRoi = (float)((((model.RentalIncome + model.MonthlyLaundryIncome + model.MonthlyMiscIncome) - (model.MonthlyMortgageExpense + model.MonthlyRentalInsuranceExpense + model.MonthlyTaxExpense + model.MonthlyUtilityExpense + model.MonthlyHoaExpense + model.MonthlyPropertyServiceExpense + model.MonthlyRepairExpense + model.MonthlyVacancyExpense + model.MonthlyManagementExpense)) * 12) / (model.EstDownPayment + model.EstClosingCost + model.EstRehabBudget)),
                    

                };
            using (var ctx = new ApplicationDbContext())
            {
                
                ctx.FourSquareAnalyses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<FourSquareListItem> GetFourSquare()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .FourSquareAnalyses
                        .Select(
                            e =>
                                new FourSquareListItem
                                {
                                    PropertyId = e.PropertyId,
                                    FourSquareDateRan = e.FourSquareDateRan,
                                    PropAddress = e.PropAddress,
                                    FourSquareAnalysisId = e.FourSquareAnalysisId,


                                });
                return query.ToArray().OrderByDescending(e => e.FourSquareDateRan );
            }
        }

        public FourSquareDetail GetFourSquareById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .FourSquareAnalyses
                        .Single(e => e.FourSquareAnalysisId == id);
                return
                    new FourSquareDetail
                    {
                        FourSquareDateRan = entity.FourSquareDateRan,
                        PropertyId = entity.PropertyId,
                        PropAddress = entity.PropAddress,
                        FourSquareAnalysisId = entity.FourSquareAnalysisId,

                        RentalIncome = entity.RentalIncome,
                        MonthlyLaundryIncome = entity.MonthlyLaundryIncome,
                        MonthlyMiscIncome = entity.MonthlyMiscIncome,
                        TotalMonthlyIncome = entity.TotalMonthlyIncome,

                        MonthlyMortgageExpense = entity.MonthlyMortgageExpense,
                        MonthlyRentalInsuranceExpense = entity.MonthlyRentalInsuranceExpense,
                        MonthlyTaxExpense = entity.MonthlyTaxExpense,
                        MonthlyUtilityExpense = entity.MonthlyUtilityExpense,
                        MonthlyHoaExpense = entity.MonthlyHoaExpense,
                        MonthlyPropertyServiceExpense = entity.MonthlyPropertyServiceExpense,
                        MonthlyRepairExpense = entity.MonthlyRepairExpense,
                        MonthlyVacancyExpense = entity.MonthlyVacancyExpense,
                        MonthlyManagementExpense = entity.MonthlyManagementExpense,
                        TotalMonthlyPropertyExpenses = entity.TotalMonthlyPropertyExpenses,

                        TotalMonthlyCashFlow = entity.TotalMonthlyCashFlow,
                        EstDownPayment = entity.EstDownPayment,
                        EstClosingCost = entity.EstClosingCost,
                        EstRehabBudget = entity.EstRehabBudget,
                        EstTotalInvestment = entity.EstTotalInvestment,
                        EstAnnaulCashFlow = entity.EstAnnaulCashFlow,

                        TotalCtcRoi = entity.TotalCtcRoi,
                        InvestmentRisk = entity.InvestmentRisk
                    };

            }
        }

        //public bool UpdateFourSquare(FourSquareEdit model)
        //{
        //    using (var ctx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            ctx
        //                .FourSquareAnalyses
        //                .Single(e => e.FourSquareAnalysisId == model.FourSquareAnalysisId);


        //        entity.MonthlyLaundryIncome = model.MonthlyLaundryIncome;
        //        entity.MonthlyMiscIncome = model.MonthlyMiscIncome;
        //        entity.MonthlyMortgageExpense = model.MonthlyMortgageExpense;
        //        entity.MonthlyRentalInsuranceExpense = model.MonthlyRentalInsuranceExpense;
        //        entity.MonthlyTaxExpense = model.MonthlyTaxExpense;
        //        entity.MonthlyUtilityExpense = model.MonthlyTaxExpense;
        //        entity.MonthlyHoaExpense = model.MonthlyHoaExpense;
        //        entity.MonthlyPropertyServiceExpense = model.MonthlyPropertyServiceExpense;
        //        entity.MonthlyRepairExpense = model.MonthlyRepairExpense;
        //        entity.MonthlyVacancyExpense = model.MonthlyVacancyExpense;
        //        entity.MonthlyManagementExpense = model.MonthlyManagementExpense;
        //        entity.EstDownPayment = model.EstDownPayment;
        //        entity.EstClosingCost = model.EstClosingCost;
        //        entity.EstRehabBudget = model.EstRehabBudget;

        //        return ctx.SaveChanges() == 1;

        //    }
        //}

        public bool DeleteFourSquare(int fourSquareId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .FourSquareAnalyses
                    .Single(e => e.FourSquareAnalysisId == fourSquareId);
                ctx.FourSquareAnalyses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
