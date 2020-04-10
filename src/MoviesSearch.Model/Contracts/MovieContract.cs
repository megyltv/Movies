using System;
using System.Collections.Generic;

namespace MoviesSearch.Model.Contracts
{
    public class MovieContract
    {
        public int Page { get; set; }
        public int Total_results { get; set; }
        public int Total_pages { get; set; }
        public IEnumerable<Result> Results { get; set; }
    }

    public class Result
    {
        public int Popularity { get; set; }
        public int Vote_count { get; set; }
        public bool Video { get; set; }
        public string Poster_path { get; set; }
        public int Id { get; set; }
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public IEnumerable<int> Genre_ids { get; set; }
        public string Title { get; set; }
        public double Vote_average { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }
    }
}