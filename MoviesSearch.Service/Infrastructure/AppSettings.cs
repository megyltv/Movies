using System;
namespace MoviesSearch.Service.Infrastructure
{
    public class AppSettings
    {
        public string ElasticSearchUrl { get; set; }
        public string IndexName { get; set; }
    }
}
