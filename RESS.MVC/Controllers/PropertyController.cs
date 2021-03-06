using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models;
using RESS.MVC.Models;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class PropertyController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly IPropertyService _service;

        public PropertyController(IPropertyService service)
        {
            _service = service;
        }

        // GET: Property/Index
        public ActionResult Index()
        {

            var model = _service.GetProperties();

            return View(model);
        }

        // GET: Property/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Property/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.CreateProperty(model))
            {
                TempData["SaveResult"] = "The property has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Property could not be created.");

            return View(model);
        }



        // GET: Property/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            
            var model = _service.GetPropertyById(id);

            return View(model);
        }

        // POST: Property/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePropertyPost(int id)
        {
            
            _service.DeleteProperty(id);
            TempData["SaveResult"] = "Property has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  Property/Update/{id}
        [ActionName("Edit")]
        public ActionResult Update(int id)
        {
            //var tenantService = new TenantService();
            //ViewBag.tenants = tenantService.GetTenant();

            var detail = _service.GetPropertyById(id);
            var model =
                new PropertyEdit
                {
                    //PropertyId = detail.PropertyId,
                    Address = detail.Address,
                    City = detail.City,
                    State = detail.State,
                    Zip = detail.Zip,
                    Beds = detail.Beds,
                    Baths = detail.Baths,
                    SquareFeet = detail.SquareFeet,
                    HomeType = detail.HomeType,
                    YearBuilt = detail.YearBuilt,
                    Heating = detail.Heating,
                    Cooling = detail.Cooling,
                    AvailableParking = detail.AvailableParking,
                    ParkingType = detail.ParkingType,
                    LotSize = detail.LotSize,
                    Basement = detail.Basement,
                    Flooring = detail.Flooring,
                    Roofing = detail.Roofing,
                    ConstructionMaterials = detail.ConstructionMaterials,
                    Neighborhood = detail.Neighborhood,
                    Parcel = detail.Parcel,
                    MarketValue = detail.MarketValue,
                    MarketRentValue = detail.MarketRentValue,
                    ThirdyDayChange = detail.ThirdyDayChange,
                    PurchaseDate = detail.PurchaseDate,
                    DownPayment = detail.DownPayment,
                    MortgageAmount = detail.MortgageAmount,
                    

                };
            return View(model);
        }

        // POST: Property/Update/{id}
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(PropertyEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.UpdateProperty(model))
            {
                TempData["SaveResult"] = "Property profile was successfully udpated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Property profile could not be updated.");
            return View();
            
        }

        // GET: Property/Details/{id}
        public ActionResult Details(int id)
        {
            
            var model = _service.GetPropertyById(id);

            return View(model);
        }

        

    }
}