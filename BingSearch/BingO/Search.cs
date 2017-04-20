using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO
{
    [Serializable]
    public class About
    {
        public string name { get; set; }
    }
    [Serializable]
    public class DeepLink
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    [Serializable]
    public class WepPageResult
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public List<About> about { get; set; }
        public string displayUrl { get; set; }
        public string snippet { get; set; }
        public List<DeepLink> deepLinks { get; set; }
        public string dateLastCrawled { get; set; }
    }
    [Serializable]
    public class WebPages
    {
        public string webSearchUrl { get; set; }
        public int totalEstimatedMatches { get; set; }
        public List<WepPageResult> value { get; set; }
    }
    [Serializable]
    public class Thumbnail
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    [Serializable]
    public class ImageResult
    {
        public string name { get; set; }
        public string webSearchUrl { get; set; }
        public string thumbnailUrl { get; set; }
        public string datePublished { get; set; }
        public string contentUrl { get; set; }
        public string hostPageUrl { get; set; }
        public string contentSize { get; set; }
        public string encodingFormat { get; set; }
        public string hostPageDisplayUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Thumbnail thumbnail { get; set; }
    }
    [Serializable]
    public class Images
    {
        public string id { get; set; }
        public string readLink { get; set; }
        public string webSearchUrl { get; set; }
        public bool isFamilyFriendly { get; set; }
        public List<ImageResult> value { get; set; }
        public bool displayShoppingSourcesBadges { get; set; }
        public bool displayRecipeSourcesBadges { get; set; }
    }
    [Serializable]
    public class Thumbnail2
    {
        public string contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
    [Serializable]
    public class Image
    {
        public string contentUrl { get; set; }
        public Thumbnail2 thumbnail { get; set; }
    }
    [Serializable]
    public class About2
    {
        public string readLink { get; set; }
        public string name { get; set; }
    }
    [Serializable]
    public class Provider
    {
        public string _type { get; set; }
        public string name { get; set; }
    }
    [Serializable]
    public class Thumbnail3
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    [Serializable]
    public class Video
    {
        public string name { get; set; }
        public string thumbnailUrl { get; set; }
        public bool allowHttpsEmbed { get; set; }
        public Thumbnail3 thumbnail { get; set; }
    }
    [Serializable]
    public class NewsSearchResult
    {
        public string name { get; set; }
        public string url { get; set; }
        public Image image { get; set; }
        public string description { get; set; }
        public List<About2> about { get; set; }
        public List<Provider> provider { get; set; }
        public string datePublished { get; set; }
        public string category { get; set; }
        public Video video { get; set; }
    }
    [Serializable]
    public class News
    {
        public string id { get; set; }
        public string readLink { get; set; }
        public List<NewsSearchResult> value { get; set; }
    }
    [Serializable]
    public class RelatedSearchResult
    {
        public string text { get; set; }
        public string displayText { get; set; }
        public string webSearchUrl { get; set; }
    }
    [Serializable]
    public class RelatedSearches
    {
        public string id { get; set; }
        public List<RelatedSearchResult> value { get; set; }
    }
    [Serializable]
    public class Publisher
    {
        public string name { get; set; }
    }
    [Serializable]
    public class Thumbnail4
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    [Serializable]
    public class VideoSearchResult
    {
        public string name { get; set; }
        public string description { get; set; }
        public string webSearchUrl { get; set; }
        public string thumbnailUrl { get; set; }
        public string datePublished { get; set; }
        public List<Publisher> publisher { get; set; }
        public string contentUrl { get; set; }
        public string hostPageUrl { get; set; }
        public string encodingFormat { get; set; }
        public string hostPageDisplayUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string duration { get; set; }
        public string motionThumbnailUrl { get; set; }
        public string embedHtml { get; set; }
        public bool allowHttpsEmbed { get; set; }
        public int viewCount { get; set; }
        public Thumbnail4 thumbnail { get; set; }
        public bool allowMobileEmbed { get; set; }
        public bool isSuperfresh { get; set; }
    }
    [Serializable]
    public class Videos
    {
        public string id { get; set; }
        public string readLink { get; set; }
        public string webSearchUrl { get; set; }
        public bool isFamilyFriendly { get; set; }
        public List<VideoSearchResult> value { get; set; }
        public string scenario { get; set; }
    }
    [Serializable]
    public class Value6
    {
        public string id { get; set; }
    }
    [Serializable]
    public class Item
    {
        public string answerType { get; set; }
        public Value6 value { get; set; }
        public int? resultIndex { get; set; }
    }
    [Serializable]
    public class Mainline
    {
        public List<Item> items { get; set; }
    }
    [Serializable]
    public class Value7
    {
        public string id { get; set; }
    }
    [Serializable]
    public class Item2
    {
        public string answerType { get; set; }
        public Value7 value { get; set; }
    }
    [Serializable]
    public class Sidebar
    {
        public List<Item2> items { get; set; }
    }
    [Serializable]
    public class RankingResponse
    {
        public Mainline mainline { get; set; }
        public Sidebar sidebar { get; set; }
    }
    [Serializable]
    public class SearchResult
    {
        public string _type { get; set; }
        public WebPages webPages { get; set; }
        public Images images { get; set; }
        public News news { get; set; }
        public RelatedSearches relatedSearches { get; set; }
        public Videos videos { get; set; }
        public RankingResponse rankingResponse { get; set; }
    }
}
