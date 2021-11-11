using RESS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Models
{
    public class PropertyEdit
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        [Display(Name = "ZIP-Code")]
        public string Zip { get; set; }
        public int Beds { get; set; }
        public decimal Baths { get; set; }
        [Display(Name = "Squarefootage")]
        public int SquareFeet { get; set; }
        [Display(Name = "Home Type")]
        public HomeType HomeType { get; set; }
        [Display(Name = "Year Built")]
        public int YearBuilt { get; set; }
        public HeatingType Heating { get; set; }
        public CoolingType Cooling { get; set; }
        [Display(Name = "Parking?")]
        public bool AvailableParking { get; set; }
        [Display(Name = "Parking Type")]
        public ParkingType ParkingType { get; set; }
        [Display(Name = "Property (Lot) Size")]
        public decimal LotSize { get; set; }  //acres
        [Display(Name = "Basement?")]
        public bool Basement { get; set; }
        public FlooringMaterials Flooring { get; set; }
        public RoofingMaterials Roofing { get; set; }
        public ConstructionMaterials ConstructionMaterials { get; set; }
        public string Neighborhood { get; set; }
        public int Parcel { get; set; }

        // Pricing
        [Display(Name = "Estimated Market Value")]
        public decimal MarketValue { get; set; }
        [Display(Name = "Estimated Market Rent Value")]
        public decimal MarketRentValue { get; set; }
        [Display(Name = "30 Day Change (%)")]
        public float ThirdyDayChange { get; set; } //Percent

        // Owner Information
        [Display(Name = "Purchase Date")]
        public DateTime? PurchaseDate { get; set; }
        [Display(Name = "Purchase Price")]
        public decimal? PurchasePrice { get; set; }
        [Display(Name = "Down Payment")]
        public decimal? DownPayment { get; set; }
        [Display(Name = "Mortgage Amount")]
        public decimal? MortgageAmount { get; set; }

        [ForeignKey(nameof(Owners))]
        [Display(Name = "Owner ID")]
        public int OwnerId { get; set; }
        public virtual Data.Owner Owners { get; set; }

        public virtual ICollection<Data.Tenant> Tenants { get; set; } //new icollection
    }
}
