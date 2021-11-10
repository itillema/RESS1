using Microsoft.AspNet.Identity;
using RESS.Data;
using RESS.Models.FourSquareAnalysis;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class FourSquareController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        private readonly IFourSquareService _service;

        public FourSquareController(IFourSquareService service)
        {
            _service = service;
        }

        // GET: FourSquare/Index
        public ActionResult Index()
        {
            
            
            var model = _service.GetFourSquare();

            return View(model);
        }

        // GET: FourSquare/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FourSquare/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FourSquareCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            

            if (_service.CreateFourSquare(model))
            {
                TempData["SaveResult"] = "Four Square Analysis has been successfully created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Four Square Analysis could not be created.");

            return View(model);
        }



        // GET: FourSquare/Delete/{id}
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            
            var model = _service.GetFourSquareById(id);

            return View(model);
        }

        // POST: FourSquare/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteFourSquarePost(int id)
        {
            
            _service.DeleteFourSquare(id);
            TempData["SaveResult"] = "Four Square Analysis has been successfully deleted";
            return RedirectToAction("Index");
        }

        // GET:  FourSquare/Update/{id}
        [ActionName("Edit")]
        public ActionResult Update(int id)
        {
           
            var detail = _service.GetFourSquareById(id);
            var model =
                new FourSquareEdit
                {
                    MonthlyLaundryIncome = detail.MonthlyLaundryIncome,
                    MonthlyMiscIncome = detail.MonthlyMiscIncome,
                    MonthlyMortgageExpense = detail.MonthlyMortgageExpense,
                    MonthlyRentalInsuranceExpense = detail.MonthlyRentalInsuranceExpense,
                    MonthlyTaxExpense = detail.MonthlyTaxExpense,
                    MonthlyUtilityExpense = detail.MonthlyTaxExpense,
                    MonthlyHoaExpense = detail.MonthlyHoaExpense,
                    MonthlyPropertyServiceExpense = detail.MonthlyPropertyServiceExpense,
                    MonthlyRepairExpense = detail.MonthlyRepairExpense,
                    MonthlyVacancyExpense = detail.MonthlyVacancyExpense,
                    MonthlyManagementExpense = detail.MonthlyManagementExpense,
                    EstDownPayment = detail.EstDownPayment,
                    EstClosingCost = detail.EstClosingCost,
                    EstRehabBudget = detail.EstRehabBudget
                };
            return View(model);
        }

        // POST: FourSquare/Update/{id}
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, FourSquareEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.FourSquareAnalysisId != id)
            {
                ModelState.AddModelError("", "Analysis ID Mismatch");
                return View(model);
            }
            
            if (_service.UpdateFourSquare(model))
            {
                TempData["SaveResult"] = "Four Square Analysis was successfully udpated and re-run.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Four Square Analysis could not be updated or re-run.");
            return View();

        }

        // GET: FourSquare/Details/{id}
        public ActionResult Details(int id)
        {
            
            var model = _service.GetFourSquareById(id);

            return View(model);
        }

        
    }
}