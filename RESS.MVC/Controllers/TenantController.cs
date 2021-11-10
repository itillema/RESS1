using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models.Tenant;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class TenantController : Controller
    {
        
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly ITenantService _service;

        public TenantController(ITenantService service)
        {
            _service = service;
        }

        // GET: Tenant/Index
        public ActionResult Index()
        {
                
           
            var model = _service.GetTenant();

            return View(model);
        }

        // GET: Tenant/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tenant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TenantCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.CreateTenant(model))
            {
                TempData["SaveResult"] = "Tenant has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Tenant could not be created.");

            return View(model);
        }



        // GET: Tenant/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            
            var model = _service.GetTenantById(id);

            return View(model);
        }

        // POST: Tenant/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteTenantPost(int id)
        {
            
            _service.DeleteTenant(id);
            TempData["SaveResult"] = "Tenant has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  Tenant/Update/{id}
        [ActionName("Edit")]
        public ActionResult Update(int id)
        {
            
            var detail = _service.GetTenantById(id);
            var model =
                new TenantEdit
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

        // POST: Tenant/Update/{id}
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, TenantEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.TenantId != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }
            
            if (_service.UpdateTenant(model))
            {
                TempData["SaveResult"] = "Tenant profile was successfully udpated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Tenant profile could not be updated.");
            return View();

        }

        // GET: Tenant/Details/{id}
        public ActionResult Details(int id)
        {
            
            var model = _service.GetTenantById(id);

            return View(model);
        }

            


    }
}