using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RESS.Data
{

    public enum HomeType
    {
        SingleFamily = 1,
        MultiFamily,
        Apartment,
        Condo,
        Townhome,
        Cabin,
        Manufactured,
        Dome
    }

    public enum ParkingType
    {
        Street = 1,
        DetatchedGarage,
        AttachedGarage,
        Lot,
        Driveway,
        None
    }

    public enum State
    {
        IL = 1,
        IN
    }

    public enum HeatingType
    {
        Furnace = 1,
        Boiler,
        Pump,
        Hybrid,
        Ductless,
        Radiant,
        Baseboard
    }

    public enum CoolingType
    {
        Central = 1,
        Ductless,
        Pump,
        EvaporativeAC
    }

    public enum FlooringMaterials
    {
        Hardwood = 1,
        Laminate,
        Vinyl,
        Porcelain,
        Tile,
        Carpet
    }

    public enum RoofingMaterials
    {
        Asphalt = 1,
        SolarTiles,
        Metal,
        StoneCoatedSteel,
        Slate,
        RubberSlate,
        Concrete,
        GreenRoof,
        BuiltUp
    }

    public enum ConstructionMaterials
    {
        Steel = 1,
        Concrete,
        Wood,
        Stone,
        Masonry
    }

    public class Property
    {
        // Property Information
        [Key]
        public int PropertyId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public State State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public int Beds { get; set; }
        [Required]
        public decimal Baths { get; set; }
        [Required]
        public int SquareFeet { get; set; }
        [Required]
        public HomeType HomeType { get; set; }
        [Required]
        public int YearBuilt { get; set; }
        [Required]
        public HeatingType Heating { get; set; }
        [Required]
        public CoolingType Cooling { get; set; }
        [Required]
        public bool AvailableParking { get; set; }
        [Required]
        public ParkingType ParkingType { get; set; }
        [Required]
        public decimal LotSize { get; set; }  
        [Required]
        public bool Basement { get; set; }
        [Required]
        public FlooringMaterials Flooring { get; set; }
        [Required]
        public RoofingMaterials Roofing { get; set; }
        [Required]
        public ConstructionMaterials ConstructionMaterials { get; set; }
        [Required]
        public string Neighborhood { get; set; }
        [Required]
        public int Parcel { get; set; }

        // Market Pricing Information
        [Required]
        public decimal MarketValue { get; set; }
        [Required]
        public decimal MarketRentValue { get; set; }
        public float? ThirdyDayChange { get; set; }

        // Owner Information
        public DateTime? PurchaseDate { get; set; }
        public TimeSpan? OwnedDuration { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? MortgageAmount { get; set; }

        [ForeignKey(nameof(Owners))]
        public int OwnerId { get; set; }
        public virtual Data.Owner Owners { get; set; }

        // Tenant Information
        [ForeignKey(nameof(Tenant))]
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }

        public List<Tenant> Tenants { get; set; }

    }
}