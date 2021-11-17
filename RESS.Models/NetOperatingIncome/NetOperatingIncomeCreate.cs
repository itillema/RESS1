using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.NetOperatingIncome
{
    public class NetOperatingIncomeCreate
    {
        [Display(Name = "Ran on")]
        public DateTime NOIRundate { get; set; }


       
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }

        
       

        // Monthly Income
        [Display(Name = "Monthly Rent Income")]
        public decimal RentalIncome { get; set; }

        [Display(Name = "Estimated Monthly Laundry Income")]
        public decimal MonthlyLaundryIncome { get; set; }
        [Display(Name = "Estimated Monthly Misc Income")]
        public decimal MonthlyMiscIncome { get; set; }
        [Display(Name = "Estimated Total Monthly Property Income")]
        public decimal TotalMonthlyIncome { get; set; }

        // Monthly Expenses
        [Display(Name = "Estimated Monthly Mortgage Expense")]
        public decimal MonthlyMortgageExpense { get; set; }
        [Display(Name = "Estimated Monthly Rental Insurance Expense")]
        public decimal MonthlyRentalInsuranceExpense { get; set; }
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
        [Display(Name = "Estimated Total Monthly Property Expense")]
        public decimal TotalMonthlyPropertyExpenses { get; set; }

        // Annual NOI
        [Display(Name = "Annual Net Operating Income")]
        public decimal AnnualNetOperatingIncome { get; set; }
        [Display(Name = "Annual Rent Increase")]
        public float AnnualRentIncreasePercent { get; set; }

        // Projected NOI Summary
        [Display(Name = "Projected 5 Year Net Operating Income")]
        public decimal FiveYearNoi { get; set; }
        [Display(Name = "Projected 15 Year Net Operating Income")]
        public decimal FifteenYearNoi { get; set; }
        [Display(Name = "Projected 30 Year Net Operating Income")]
        public decimal ThirtyYearNoi { get; set; }

        

    }
}
