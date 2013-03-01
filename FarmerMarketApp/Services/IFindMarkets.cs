using FarmerMarketApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerMarketApp.Services {
    interface IFindMarkets {
        ResultViewModel             GetClosestMarket(double x, double y);
        List<ResultViewModel>       GetMarketsWithinRange(double x, double y, double distance); // each tuple is the market and then the distance from the provided location

    }
}


// Do I actually gain anything from using interfaces here? Decoupling, for testing/MOQing purposes?
// Am I doing them right?