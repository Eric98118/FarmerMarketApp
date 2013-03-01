using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FarmerMarketApp.Models {
    public class SearchInput {
        [Required]
        [DisplayName("Longitude")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180 degrees")]
        public double x { get; set; }

        [Required]
        [DisplayName("Latitude")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90 degrees")]
        public double y { get; set; }

        private const double _earthCircumferance = 40075000;
        [Range(0, _earthCircumferance)]
        [DisplayName("Distance (in meters)")]
        public double? distance { get; set; }
    }
}