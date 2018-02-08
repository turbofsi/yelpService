using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExternalService.Models.YelpService
{
    public class YelpSearchResult
    {
        public int Total { get; set; }
        public List<Business> Businesses { get; set; }
        public Center Region { get; set; }
    }
}