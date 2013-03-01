using FarmerMarketApp.ViewModels;
using FarmerMarketApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmerMarketApp.Controllers {
    public class MarketSearchController : ApiController {

        // GET api/marketsearch
        // Returns all markets in the db
        public IEnumerable<string> Get() {
            return new string[] { "Not Yet", "Implemented" };
        }

        // GET api/marketsearch?xloc=1.5&yloc=4.5
        // Returns the closest market to the listed location + distance
        // distance is in meters
        public ResultViewModel Get(double xloc, double yloc) {
            var marketFinder = new FindFarmerMarkets();
            ResultViewModel closestMarket = marketFinder.GetClosestMarket(xloc, yloc);
            return closestMarket;
        }

        // GET api/marketsearch?xloc=1.5&yloc=4.5&distance=5
        // Returns all the markets that are within the specified distance from the provided location
        // distance is in meters
        public List<ResultViewModel> Get(double xloc, double yloc, double distance) {
            var marketFinder = new FindFarmerMarkets();
            List<ResultViewModel> nearMarkets = marketFinder.GetMarketsWithinRange(xloc, yloc, distance);
            return nearMarkets;
        }
    }
}
