using System.Collections.Generic;

namespace HikariWatch
{
    public class AnimeSource
    {
        public string SourceName { get; set; }
        public string BaseUrl { get; set; }
        public string Lang { get; set; }
        public PopularAnime PopularAnime { get; set; }
        public LatestUpdates LatestUpdates { get; set; }
        public SearchAnime SearchAnime { get; set; }
        public Filters Filters { get; set; }
        public List<VideoSource> VideoSources { get; set; }
    }

    public class PopularAnime
    {
        public string Endpoint { get; set; }
        public string Selector { get; set; }
        public Fields Fields { get; set; }
    }

    public class LatestUpdates
    {
        public string Endpoint { get; set; }
        public string Selector { get; set; }
        public Fields Fields { get; set; }
    }

    public class SearchAnime
    {
        public string Endpoint { get; set; }
        public string Selector { get; set; }
        public Fields Fields { get; set; }
    }

    public class Fields
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public Thumbnail Thumbnail { get; set; }
    }

    public class Thumbnail
    {
        public string Src { get; set; }
        public string DataAttr { get; set; }
    }

    public class Filters
    {
        public List<Genre> Genre { get; set; }
    }

    public class Genre
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class VideoSource
    {
        public string ProviderName { get; set; }
        public string Url { get; set; }
        public string EmbedUrl { get; set; }
        public string Quality { get; set; }
        public ExtractionMethod ExtractionMethod { get; set; }
    }

    public class ExtractionMethod
    {
        public string Regex { get; set; }
        public string ElementSelector { get; set; }
        public string SrcAttr { get; set; }
    }
}
