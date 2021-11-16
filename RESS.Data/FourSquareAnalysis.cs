using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Data
{

    public enum InvestmentRiskType
    {
        VeryLow = 1,
        ModeratelyLow,
        Moderate,
        ModeratelyHigh,
        VeryHigh
    }

    public class FourSquareAnalysis
    {
        // Analysis Identifiers
        [Key]
        public int FourSquareAnalysisId { get; set; }
        public DateTime FourSquareDateRan { get; set; }

        

        //[ForeignKey(nameof(Properties))]
        public int PropertyId { get; set; }
       
        //nested link

        
        // Monthly Income

        public decimal RentalIncome { get; set; }
        public decimal MonthlyLaundryIncome { get; set; }
        public decimal MonthlyMiscIncome { get; set; }
        public decimal TotalMonthlyIncome { get; set; }

        // Monthly Expenses
        public decimal MonthlyMortgageExpense { get; set; }
        public decimal MonthlyRentalInsuranceExpense { get; set; }
        public decimal MonthlyTaxExpense { get; set; }
        public decimal MonthlyUtilityExpense { get; set; }
        public decimal MonthlyHoaExpense { get; set; }
        public decimal MonthlyPropertyServiceExpense { get; set; }
        public decimal MonthlyVacancyExpense { get; set; }
        public decimal MonthlyRepairExpense { get; set; }
        public decimal MonthlyManagementExpense { get; set; }
        public decimal TotalMonthlyPropertyExpenses { get; set; }

        // Monthly Cash Flow
        public decimal TotalMonthlyCashFlow { get; set; }

        // Cash to Cash ROI
        public decimal EstDownPayment { get; set; }
        public decimal EstClosingCost { get; set; }
        public decimal EstRehabBudget { get; set; }
        public decimal EstTotalInvestment { get; set; }
        public decimal EstAnnaulCashFlow { get; set; }
        public float TotalCtcRoi { get; set; }

        //// Analytic Result Summary
        //public InvestmentRiskType? InvestmentRisk { get; set; }

        



    }
}
