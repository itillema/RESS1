using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models.NetOperatingIncome;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class NOIController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: NetOperatingIncome/Index
        public ActionResult Index()
        {
            
            var service = new NetOperatingIncomeService();
            var model = service.GetNetOperatingIncome();

            return View(model);
        }

        // GET: NetOperatingIncome/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: NetOperatingIncome/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NetOperatingIncomeCreate model)
        {
            if (ModelState.IsValid) return View(model);

            var service = new NetOperatingIncomeService();

            if (service.CreateNetOperatingIncome(model))
            {
                TempData["SaveResult"] = "NetOperatingIncome has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "NetOperatingIncome could not be created.");

            return View(model);
        }



        // GET: NetOperatingIncome/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = new NetOperatingIncomeService();
            var model = svc.GetNetOperatingIncomeById(id);

            return View(model);
        }

        // POST: NetOperatingIncome/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteNetOperatingIncomePost(int id)
        {
            var service = new NetOperatingIncomeService();
            service.DeleteNetOperatingIncome(id);
            TempData["SaveResult"] = "NetOperatingIncome has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  NetOperatingIncome/Update/{id}
        [ActionName("Edit")]
        public ActionResult Update(int id)
        {
            var service = new NetOperatingIncomeService();
            var detail = service.GetNetOperatingIncomeById(id);
            var model =
                new NetOperatingIncomeEdit
                {

                    /*TenantFirstName = detail.TenantFirstName,
                    TenantLastName = detail.TenantLastName,
                    MobileNo = detail.MobileNo,
                    LeaseStart = detail.LeaseStart,
                    LeaseEnd = detail.LeaseEnd,
                    SecurityDeposit = detail.SecurityDeposit,
                    RentAmount = detail.RentAmount*/
                };
            return View(model);
        }

        // POST: NetOperatingIncome/Update/{id}
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, NetOperatingIncomeEdit model)
        {
            if (ModelState.IsValid) return View(model);

            if (model.NetOperatingIncomeId != id)
            {
                ModelState.AddModelError("", "ID Mismatch");
                return View(model);
            }
            var service = new NetOperatingIncomeService();
            if (service.UpdateNetOperatingIncome(model))
            {
                TempData["SaveResult"] = "NetOperatingIncome profile was successfully udpated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "NetOperatingIncome profile could not be updated.");
            return View();

        }

        // GET: NetOperatingIncome/Details/{id}
        public ActionResult Details(int id)
        {
            var svc = new NetOperatingIncomeService();
            var model = svc.GetNetOperatingIncomeById(id);

            return View(model);
        }

        
    }
}