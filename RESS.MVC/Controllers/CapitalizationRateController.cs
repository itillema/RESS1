using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models.CapitalizationRate;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class CapitalizationRateController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly ICapitalizationRateService _service;

        public CapitalizationRateController(ICapitalizationRateService service)
        {
            _service = service;
        }

        // GET: CapitalizationRate/Index
        public ActionResult Index()
        {
            
            
            var model = _service.GetCapitalizationRate();

            return View(model);
        }

        // GET: CapitalizationRate/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapitalizationRate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CapitalizationRateCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.CreateCapitalizationRate(model))
            {
                TempData["SaveResult"] = "CapitalizationRate has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "CapitalizationRate could not be created.");

            return View(model);
        }



        // GET: CapitalizationRate/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            
            var model = _service.GetCapitalizationRateById(id);

            return View(model);
        }

        // POST: CapitalizationRate/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCapitalizationRatePost(int id)
        {
            
            _service.DeleteCapitalizationRate(id);
            TempData["SaveResult"] = "CapitalizationRate has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  CapitalizationRate/Update/{id}
        /*[ActionName("Edit")]
        public ActionResult Update(int id)
        {
            var service = CreateCapitalizationRateService();
            var detail = service.GetCapitalizationRateById(id);
            var model =
                new CapitalizationRateEdit
                {

                    TenantFirstName = detail.TenantFirstName,
                    TenantLastName = detail.TenantLastName,
                    MobileNo = detail.MobileNo,
                    LeaseStart = detail.LeaseStart,
                    LeaseEnd = detail.LeaseEnd,
                    SecurityDeposit = detail.SecurityDeposit,
                    RentAmount = detail.RentAmount
                };
            return View(model);
        }

        // POST: CapitalizationRate/Update/{id}
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, CapitalizationRateEdit model)
        {
            if (ModelState.IsValid) return View(model);

            if (model.TenantId != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }
            var service = CreateTenantService();
            if (service.UpdateTenant(model))
            {
                TempData["SaveResult"] = "Tenant profile was successfully udpated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Tenant profile could not be updated.");
            return View();

        }*/

        // GET: CapitalizationRate/Details/{id}
        public ActionResult Details(int id)
        {
            
            var model = _service.GetCapitalizationRateById(id);

            return View(model);
        }

        
    }
}