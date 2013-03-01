using FarmerMarketApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Web;

namespace FarmerMarketApp.Services {
    public class FindFarmerMarkets : IFindMarkets {
        public ResultViewModel GetClosestMarket(double inputx, double inputy) {
            using (var context = new MarketsEntities()) {

                //var query = (from fm in context.FarmerMarkets
                //             let dif = (Math.Abs((double)fm.x - inputx) + Math.Abs((double)fm.y - inputy))
                //             orderby dif ascending
                //             select fm).First();
                //double distance = Math.Abs((double)market.x - inputx) + Math.Abs((double)market.y - inputy);
                DbGeography startLoc = DbGeography.PointFromText(string.Format("POINT({0} {1})", inputx, inputy), 4326);
                var query = (from fm in context.FarmerMarkets
                             let dif = fm.GeoLocation.Distance(startLoc)
                             orderby dif ascending
                             select fm).First();
                FarmerMarket market = query;
                double distance = (double)market.GeoLocation.Distance(startLoc);
                
                return ConvertToResult(market, distance); 
            }
        }

        // distance is in meters
        public List<ResultViewModel> GetMarketsWithinRange(double inputx, double inputy, double distance) {

            using (var context = new MarketsEntities()) {
                DbGeography startLoc = DbGeography.PointFromText(string.Format("POINT({0} {1})", inputx, inputy), 4326);
                var marketQuery =   (from fm in context.FarmerMarkets
                                     let dif = fm.GeoLocation.Distance(startLoc)
                                     where dif < distance
                                     orderby dif ascending
                                     select fm);
                var results = new List<ResultViewModel>();
                foreach (var market in marketQuery) {
                    var difference = (double)market.GeoLocation.Distance(startLoc);
                    results.Add(ConvertToResult(market, difference));
                }
                return results;
            }
        }

        private ResultViewModel ConvertToResult(FarmerMarket inputFMarket, double distance) {
            ResultViewModel result = new ResultViewModel {
                Name = inputFMarket.MarketName,
                X = (double)inputFMarket.x,
                Y = (double)inputFMarket.y,
                Distance = distance,
                Website = inputFMarket.Website,
                Schedule = inputFMarket.Schedule
            };

            return result;
        }

        // Doing this x + y rather than as the crow flies, since roads are usually on a grid
        // Note: probably already in a library somewhere, can switch to that later
        // Todo: add checking to make sure the input parameters are within a valid range
        //
        // value returned is in meters
        private double GetDistance(double x1, double y1, double x2, double y2) {
            DbGeography location1 = DbGeography.PointFromText(string.Format("POINT({0} {1})", y1, x1), 4326);
            DbGeography location2 = DbGeography.PointFromText(string.Format("POINT({0} {1})", y2, x2), 4326);
            var distance = location1.Distance(location2);
            return (double)distance;
        }
    }
}