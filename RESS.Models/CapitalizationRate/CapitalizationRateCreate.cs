﻿using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models.CapitalizationRate
{
    public class CapitalizationRateCreate
    {
        // Analysis Identifiers
        
        [Display(Name = "Ran on")]
        public DateTime CapRateRunDate { get; set; }

        [ForeignKey(nameof(Property))]
        [Display(Name = "Property ID")]
        public int PropertyId { get; set; }
        public string Address { get; set; }
        [Display(Name = "Market Rent Value")]
        public decimal MarketRentValue { get; set; }
        [Display(Name = "Property Market Value")]
        public decimal MarketValue { get; set; }
        public virtual Property Property { get; set; }

        [ForeignKey(nameof(Owner))]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        [Display(Name = "Property Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [Display(Name = "Duration of Ownership")]
        public TimeSpan OwnedDuration { get; set; }
        public virtual Data.Owner Owner { get; set; }


        // Monhtly Income
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

        // NOI
        [Display(Name = "Annual Net Operating Income")]
        public decimal AnnualNetOperatingIncome { get; set; }
        [Display(Name = "Annual Rent Increase")]
        public float AnnualRentIncreasePercent { get; set; }

        // CapRate
        [Display(Name = "Current Capitalization Rate")]
        public float CurrentCapitalizationRate { get; set; }
        [Display(Name = "Projected 5 Year Capitalization Rate")]
        public float EstFiveYearCapitalizationRate { get; set; }
        [Display(Name = "Projected 15 Year Capitalization Rate")]
        public float EstFifteenYearCapitalizationRate { get; set; }
        [Display(Name = "Projected 30 Year Capitalization Rate")]
        public float EstThirtyYearCapitalizationRate { get; set; }
        [Display(Name = "Ownered Duration Capitalization Rate")]
        public float OwnedDurationCapitalizationRate { get; set; }
    }
}