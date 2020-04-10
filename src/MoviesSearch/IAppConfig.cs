namespace MoviesSearch.API
{
    public interface IAppConfig
    {
        string ElasticSearchUrl { get; }
        string IndexName { get; }
    }
}
