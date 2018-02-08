using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExternalService.Models.YelpService
{
    public class Location
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public List<string> display_address { get; set; }
    }
}