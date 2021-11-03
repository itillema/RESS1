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

    public class PropertyListItem
    {
        [Display(Name="Property ID")]
        public int PropertyId { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public State State { get; set; }
        public string Zip { get; set; }
        

    }

}
