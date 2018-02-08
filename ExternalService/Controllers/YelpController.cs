using ExternalService.Clients;
using ExternalService.Models.YelpService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExternalService.Controllers
{
    [RoutePrefix("api/yelp")]
    public class YelpController : ApiController
    {
        private IYelpRestApiClient _yelpClient;
        public YelpController(IYelpRestApiClient yelpClient)
        {
            _yelpClient = yelpClient;
        }


        [HttpGet]
        [Route("search")]
        public IHttpActionResult GetYelpSearchResult(string term, string city, string zipCode)
        {
            var result = _yelpClient.GetYelpSearchResult(term, city, zipCode);

            return Ok(result);

        }
    }
}
