using Microsoft.Extensions.Options;
using MoviesSearch.API;

namespace MoviesSearch.Service.Infrastructure
{
    public class AppConfig : IAppConfig
    {
        private readonly AppSettings _appSettings;

        public AppConfig(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }

        public string ElasticSearchUrl => _appSettings.ElasticSearchUrl;

        public string IndexName => _appSettings.IndexName;
    }
}
