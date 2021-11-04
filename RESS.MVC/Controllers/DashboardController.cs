using Microsoft.AspNet.Identity;
using RESS.Models.Portal;
using RESS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESS.MVC.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            var capRateService = new CapitalizationRateService();
            var fourSqareService = new FourSquareService();
            var netOperatingIncomeService = new NetOperatingIncomeService();
            var model = new DashboardViewModel();
            model.MostRecentCapRateAnalyses = capRateService.MostRecentCapitalizationRateAnalysis();
            model.MostRecentFourSqrAnalyses = fourSqareService.MostRecentFourSquareAnalysis();
            model.MostRecentNOIAnalyses = netOperatingIncomeService.MostNetOperatingIncomeAnalysis();

            return View();
        }
    }
}