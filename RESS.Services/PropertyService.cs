using RESS.Data;
using RESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class PropertyService
    {

        public bool CreateProperty(PropertyCreate model)
        {
            var entity =
                new Property()
                {
                    Address = model.Address,
                    City = model.City,
                    State = (Data.State)model.State,
                    Zip = model.Zip,
                    Beds = model.Beds,
                    Baths = model.Baths,
                    SquareFeet = model.SquareFeet,
                    HomeType = (Data.HomeType)model.HomeType,
                    YearBuilt = model.YearBuilt,
                    Heating = (Data.HeatingType)model.Heating,
                    Cooling = (Data.CoolingType)model.Cooling,
                    AvailableParking = model.AvailableParking,
                    ParkingType = (Data.ParkingType)model.ParkingType,
                    LotSize = model.LotSize,
                    Basement = model.Basement,
                    Flooring = (Data.FlooringMaterials)model.Flooring,
                    Roofing = (Data.RoofingMaterials)model.Roofing,
                    ConstructionMaterials = (Data.ConstructionMaterials)model.ConstructionMaterials,
                    Neighborhood = model.Neighborhood,
                    Parcel = model.Parcel,
                    MarketValue = model.MarketValue,
                    MarketRentValue = model.MarketRentValue,
                    ThirdyDayChange = model.ThirdyDayChange,
                    PurchaseDate = model.PurchaseDate,
                    PurchasePrice = model.PurchasePrice,
                    DownPayment = model.DownPayment,
                    MortgageAmount = model.MortgageAmount,
                    Owners = model.Owners,
                    Tenants = model.Tenants

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Properties.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PropertyListItem> GetProperties()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Properties
                        .Select(
                            e => 
                                new PropertyListItem
                                {
                                    PropertyId = e.PropertyId,
                                    Address = e.Address,
                                    City = e.City,
                                    State = (Models.State)e.State,
                                    Zip = e.Zip,

                                });
                return query.ToArray();
            }
        }

        public PropertyDetail GetPropertyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Properties
                        .Single(e => e.PropertyId == id);
                return
                    new PropertyDetail
                    {
                        PropertyId = entity.PropertyId,
                        Address = entity.Address,
                        City = entity.City,
                        State = (Models.State)entity.State,
                        Zip = entity.Zip,
                        Beds = entity.Beds,
                        Baths = entity.Baths,
                        SquareFeet = entity.SquareFeet,
                        HomeType = (Models.HomeType)entity.HomeType,
                        YearBuilt = entity.YearBuilt,
                        Heating = (Models.HeatingType)entity.Heating,
                        Cooling = (Models.CoolingType)entity.Cooling,
                        AvailableParking = entity.AvailableParking,
                        ParkingType = (Models.ParkingType)entity.ParkingType,
                        LotSize = entity.LotSize,
                        Basement = entity.Basement,
                        Flooring = (Models.FlooringMaterials)entity.Flooring,
                        Roofing = (Models.RoofingMaterials)entity.Roofing,
                        ConstructionMaterials = (Models.ConstructionMaterials)entity.ConstructionMaterials,
                        Neighborhood = entity.Neighborhood,
                        Parcel = entity.Parcel,
                        MarketValue = entity.MarketValue,
                        MarketRentValue = entity.MarketRentValue,
                        ThirdyDayChange = (float)entity.ThirdyDayChange,
                        PurchaseDate = entity.PurchaseDate,
                        OwnedDuration = entity.OwnedDuration,
                        PurchasePrice = entity.PurchasePrice,
                        DownPayment = entity.DownPayment,
                        MortgageAmount = entity.MortgageAmount,
                        Owners = entity.Owners,
                        Tenants = entity.Tenants

                    };
            }
        }

        public bool UpdateProperty(PropertyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Properties
                        .Single(e => e.PropertyId == model.PropertyId);

                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = (Data.State)model.State;
                entity.Zip = model.Zip;
                entity.Beds = model.Beds;
                entity.Baths = model.Baths;
                entity.SquareFeet = model.SquareFeet;
                entity.HomeType = (Data.HomeType)model.HomeType;
                entity.YearBuilt = model.YearBuilt;
                entity.Heating = (Data.HeatingType)model.Heating;
                entity.Cooling = (Data.CoolingType)model.Cooling;
                entity.AvailableParking = model.AvailableParking;
                entity.ParkingType = (Data.ParkingType)model.ParkingType;
                entity.LotSize = model.LotSize;
                entity.Basement = model.Basement;
                entity.Flooring = (Data.FlooringMaterials)model.Flooring;
                entity.Roofing = (Data.RoofingMaterials)model.Roofing;
                entity.ConstructionMaterials = (Data.ConstructionMaterials)model.ConstructionMaterials;
                entity.Neighborhood = model.Neighborhood;
                entity.Parcel = model.Parcel;
                entity.MarketValue = model.MarketValue;
                entity.MarketRentValue = model.MarketRentValue;
                entity.ThirdyDayChange = model.ThirdyDayChange;
                entity.PurchaseDate = model.PurchaseDate;
                entity.PurchasePrice = model.PurchasePrice;
                entity.DownPayment = model.DownPayment;
                entity.MortgageAmount = model.MortgageAmount;
                entity.Owners = model.Owners;
                entity.Tenants = model.Tenants;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteProperty(int propertyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Properties
                    .Single(e => e.PropertyId == propertyId);
                ctx.Properties.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        
    }
}
