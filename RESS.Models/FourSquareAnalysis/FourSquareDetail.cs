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

    public class FourSquareDetail
    {
        // Analysis Identifiers
        [Display(Name = "Four Square Analysis ID")]
        public int FourSquareAnalysisId { get; set; }
        [Display(Name = "Ran on")]
        public DateTime FourSquareDateRan { get; set; }

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        [Display(Name = "Market Rent Value")]
        public decimal MarketRentValue { get; set; }
        public virtual Property Property { get; set; }


        // Monthly Income
        [Display(Name = "Monthly Laundry Income")]
        public decimal MonthlyLaundryIncome { get; set; }
        [Display(Name = "Monthly Misc Income")]
        public decimal MonthlyMiscIncome { get; set; }
        [Display(Name = "Total Monthly Income")]
        public decimal TotalMonthlyIncome { get; set; }

        // Monthly Expenses
        [Display(Name = "Mortgage Expense")]
        public decimal MonthlyMortgageExpense { get; set; }
        [Display(Name = "Rental Insurance Expense")]
        public decimal MonthlyRentalInsuranceExpense { get; set; }
        [Display(Name = "Tax Expense")]
        public decimal MonthlyTaxExpense { get; set; }
        [Display(Name = "Utility Expense")]
        public decimal MonthlyUtilityExpense { get; set; }
        [Display(Name = "HOA Expense")]
        public decimal MonthlyHoaExpense { get; set; }
        [Display(Name = "Property Service Expense")]
        public decimal MonthlyPropertyServiceExpense { get; set; }
        [Display(Name = "Vacancy Expense")]
        public decimal MonthlyVacancyExpense { get; set; }
        [Display(Name = "Repair Expense")]
        public decimal MonthlyRepairExpense { get; set; }
        [Display(Name = "Management Expense")]
        public decimal MonthlyManagementExpense { get; set; }
        [Display(Name = "Total Monthly Expenses")]
        public decimal TotalMonthlyPropertyExpenses { get; set; }

        // Monthly Cash Flow
        [Display(Name = "Total Monthly Cash Flow")]
        public decimal TotalMonthlyCashFlow { get; set; }

        // Cash to Cash ROI
        [Display(Name = "Estimated Down Payment")]
        public decimal EstDownPayment { get; set; }
        [Display(Name = "Estimated Closing Costs")]
        public decimal EstClosingCost { get; set; }
        [Display(Name = "Estimated Rehab Budget")]
        public decimal EstRehabBudget { get; set; }
        [Display(Name = "Estimated Total Property Investment")]
        public decimal EstTotalInvestment { get; set; }
        [Display(Name = "Estimated Annual Cash Flow")]
        public decimal EstAnnaulCashFlow { get; set; }
        [Display(Name = "Total Cash-to-Cash ROI")]
        public float TotalCtcRoi { get; set; }

        // Analytic Result Summary
        [Display(Name = "Investment Risk Summary")]
        public InvestmentRiskType InvestmentRisk { get; set; }
    }
}
