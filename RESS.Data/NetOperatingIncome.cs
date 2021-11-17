using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Data
{
    public class NetOperatingIncome
    {
        // Analysis Identifiers
        [Key]
        public int NetOperatingIncomeId { get; set; }
        public DateTime NOIRundate { get; set; }

        //public string PropAddress { get; set; }

        //[ForeignKey(nameof(Properties))]
        public int PropertyId { get; set; }
        
        

        // Monthly Income

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

        // Annual NOI
        public decimal AnnualNetOperatingIncome { get; set; }
        public float AnnualRentIncreasePercent { get; set; }

        // Projected NOI Summary
        public decimal FiveYearNoi { get; set; }
        public decimal FifteenYearNoi { get; set; }
        public decimal ThirtyYearNoi { get; set; }

        //[Required]
        //public virtual Property Properties { get; set; }

    }
}
