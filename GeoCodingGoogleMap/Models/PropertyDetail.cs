using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeocodingGoogleMap.Models
{
    public class PropertyDetail
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public int PropertyId { get; set; }
    }
}