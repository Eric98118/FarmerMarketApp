using FarmerMarketApp.Models;
using FarmerMarketApp.Services;
using FarmerMarketApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmerMarketApp.Controllers {
    public partial class HomeController : Controller {
        //
        // GET: /Home/

        public virtual ActionResult Index() {
            return View();
        }

        public virtual ActionResult Search() {
            return View();
        }

        public virtual ActionResult ShowResults(double distance, double x, double y) {
            // Now, time to get results
            var marketFinder = new FindFarmerMarkets();
            ViewBag.Distance = distance;
            List<ResultViewModel> markets = marketFinder.GetMarketsWithinRange(x, y, distance);
            return View(markets);
        }

        // spreading this out from show results is a bit silly, mostly for experimental reasons
        public virtual ActionResult ShowSingleResult(double x, double y) {
            var marketFinder = new FindFarmerMarkets();
            ResultViewModel market = marketFinder.GetClosestMarket(x, y);
            return View(market);
        }

        [HttpPost]
        public virtual ActionResult Search(SearchInput model) {
            if (ModelState.IsValid) {
                if (model.distance != null) {
                    return RedirectToAction(MVC.Home.ShowResults((double)model.distance, model.x, model.y));
                } else {
                    return RedirectToAction(MVC.Home.ShowSingleResult(model.x, model.y));
                }
            } else {
                return View(model);
            }

        }

    }
}