using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models.Owner;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class OwnerController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly IOwnerService _service;

        public OwnerController(IOwnerService service)
        {
            _service = service;
        }

        // GET: Owner/Index
        public ActionResult Index()
        {
            
            
            var model = _service.GetOwner();

            return View(model);
        }

        // GET: Owner/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OwnerCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.CreateOwner(model))
            {
                TempData["SaveResult"] = "Owner has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Owner could not be created.");

            return View(model);
        }



        // GET: Owner/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
           
            var model = _service.GetOwnerById(id);

            return View(model);
        }

        // POST: Owner/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteOwnerPost(int id)
        {
            
            _service.DeleteOwner(id);
            TempData["SaveResult"] = "Owner has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  Owner/Update/{id}
        [ActionName("Update")]
        public ActionResult Update(int id)
        {
            
            var detail = _service.GetOwnerById(id);
            var model =
                new OwnerEdit
                {
                    OwnerFirstName = detail.OwnerFirstName,
                    OwnerLastName = detail.OwnerLastName,
                    MobileNo = detail.MobileNo,
                    Email = detail.Email,
                    
                };
            return View(model);
        }

        // POST: Owner/Update/{id}
        [HttpPost]
        [ActionName("Update")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, OwnerEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.OwnerId != id)
            {
                ModelState.AddModelError("", "Owner ID Mismatch");
                return View(model);
            }
            
            if (_service.UpdateOwner(model))
            {
                TempData["SaveResult"] = "Owner profile was successfully udpated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Owner profile could not be updated.");
            return View();

        }

        // GET: Owner/Details/{id}
        public ActionResult Details(int id)
        {
            
            var model = _service.GetOwnerById(id);

            return View(model);
        }

        
    }
}