using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExternalService.Models.YelpService;
using RestSharp;
using ExternalService.Constants;
using System.Net;
using Newtonsoft.Json;

namespace ExternalService.Clients
{
    public class YelpRestApiClient : IYelpRestApiClient
    {
        private readonly IRestClient _restClient;

        public YelpRestApiClient()
        {
            _restClient = new RestClient();
            _restClient.BaseUrl = new Uri(StringConstants.YELP_API_PATH);
        }
        public YelpSearchResult GetYelpSearchResult(string term, string city, string state, string zipCode)
        {
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = string.Format("/search")
            };

            request.AddParameter("term", term, ParameterType.QueryString);
            request.AddParameter("location", string.Format("city={0}&state={1}&zip_code", city, state, zipCode), ParameterType.QueryString);

            _restClient.AddDefaultHeader("Authorization", "Bearer " + StringConstants.YELP_API_TOKEN);

            var response = _restClient.Execute(request);

            var result = new YelpSearchResult();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<YelpSearchResult>(response.Content);
            }

            return result;
        }
    }
}