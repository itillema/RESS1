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
    public class FourSquareEdit
    {
        // Analysis Identifiers
        [Display(Name = "Four Square Analysis ID")]
        public int FourSquareAnalysisId { get; set; }


        // Monthly Income
        [Display(Name = "Monthly Laundry Income")]
        public decimal MonthlyLaundryIncome { get; set; }
        [Display(Name = "Monthly Misc Income")]
        public decimal MonthlyMiscIncome { get; set; }
       

        // Monthly Expenses
        [Display(Name = " Estimated Monthly Mortgage Expense")]
        public decimal MonthlyMortgageExpense { get; set; }
        [Display(Name = "Estimated Monthly Rental Insurance Expense")]
        public decimal MonthlyRentalInsuranceExpense { get; set; }
        [Display(Name = "Estimated Monthly Tax Expense")]
        public decimal MonthlyTaxExpense { get; set; }
        [Display(Name = "Estimated Monthly Utility Expense")]
        public decimal MonthlyUtilityExpense { get; set; }
        [Display(Name = "Estimated Monthly HOA Expense")]
        public decimal MonthlyHoaExpense { get; set; }
        [Display(Name = "Estimated Monthly Property Service Expense")]
        public decimal MonthlyPropertyServiceExpense { get; set; }
        [Display(Name = "Estimated Monthly Vacancy Expense")]
        public decimal MonthlyVacancyExpense { get; set; }
        [Display(Name = "Estimated Monthly Repair Expense")]
        public decimal MonthlyRepairExpense { get; set; }
        [Display(Name = "Estimated Monthly Management Expense")]
        public decimal MonthlyManagementExpense { get; set; }


        // Cash to Cash ROI
        [Display(Name = "Estimated Down Payment")]
        public decimal EstDownPayment { get; set; }
        [Display(Name = "Estimated Closing Costs")]
        public decimal EstClosingCost { get; set; }
        [Display(Name = "Estimated Rehab Budget")]
        public decimal EstRehabBudget { get; set; }
        
    }
}
