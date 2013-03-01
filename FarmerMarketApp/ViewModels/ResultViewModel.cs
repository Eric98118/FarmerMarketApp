using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmerMarketApp.ViewModels {
    public class ResultViewModel {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Schedule { get; set; }
    }
}