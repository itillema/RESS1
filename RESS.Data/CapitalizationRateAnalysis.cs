using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Data
{
    public class CapitalizationRateAnalysis
    {
        // Analysis Identifiers
        [Key]
        public int CapitalizationRateAnalysisId { get; set; }
        public DateTime CapRateRunDate { get; set; }
        

        //[ForeignKey(nameof(Properties))]
        public int PropertyId { get; set; }
        
       

        //[ForeignKey(nameof(Owners))]
        public int OwnerId { get; set; }
        
        


        // Monhtly Income
        public decimal RentalIncome { get; set; }
        public decimal MonthlyLaundryIncome { get; set; }
        public decimal MonthlyMiscIncome { get; set; }
        public decimal TotalMonthlyIncome { get; set; }


        // Monthly Expenses
        public decimal MonthlyMortgageExpense { get; set; }
        public decimal MonthlyRentalInsuranceExpense { get; set; }
        public decimal MonthlyUtilityExpense { get; set; }
        public decimal MonthlyHoaExpense { get; set; }
        public decimal MonthlyPropertyServiceExpense { get; set; }
        public decimal MonthlyVacancyExpense { get; set; }
        public decimal MonthlyRepairExpense { get; set; }
        public decimal MonthlyManagementExpense { get; set; }
        public decimal TotalMonthlyPropertyExpenses { get; set; }

        // NOI
        public decimal AnnualNetOperatingIncome { get; set; }
        public float AnnualRentIncreasePercent { get; set; }
        
        public decimal PropPurchasePrice { get; set; }
        

        // CapRate
        public float CurrentCapitalizationRate { get; set; }
        public float EstFiveYearCapitalizationRate { get; set; }
        public float EstFifteenYearCapitalizationRate { get; set; }
        public float EstThirtyYearCapitalizationRate { get; set; }
       

        

    }
}
