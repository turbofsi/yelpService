using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExternalService.Models.YelpService
{
    public class Business
    {
        public string id { get; set; }
        public string name { get; set; }
        public string image_url { get; set; }
        public bool is_closed { get; set; }
        public string url { get; set; }
        public int review_count { get; set; }
        public List<Category> categories { get; set; }
        public string rating { get; set; }
        public Coordinates coordinates { get; set; }
        public string[] transactions { get; set; }
        public Location location { get; set; }
        public string phone { get; set; }
        public string display_phone { get; set; }
        public double distance { get; set; }
    }
}