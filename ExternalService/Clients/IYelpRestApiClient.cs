using ExternalService.Models.YelpService;

namespace ExternalService.Clients
{
    public interface IYelpRestApiClient
    {
        YelpSearchResult GetYelpSearchResult(string term, string city, string zipCode);
    }
}
