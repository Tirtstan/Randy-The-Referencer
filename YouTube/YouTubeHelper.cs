using System.Web;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace Randy_The_Referencer;

public static class YouTubeHelper
{
    public static bool IsYouTubeInitialized { get; private set; }
    public static YouTubeService YouTubeService { get; private set; }
    private static string[] validHosts = { "youtube.com", "youtu.be", "www.youtube.com" };

    public static bool IsYouTubeLink(string link)
    {
        bool valid = false;
        try
        {
            string host = new Uri(link).Host.ToLower();
            valid = validHosts.Contains(host);
        }
        catch
        {
            valid = false;
        }

        return valid;
    }

    public static string? GetVideoId(string link) // https://stackoverflow.com/a/39777772/19860255
    {
        var uri = new Uri(link);
        var query = HttpUtility.ParseQueryString(uri.Query);

        string videoId;
        if (query.AllKeys.Contains("v"))
        {
            videoId = query["v"];
        }
        else
        {
            videoId = uri.Segments.Last();
        }

        return videoId;
    }

    public static bool InitializeYouTubeAPI()
    {
        try
        {
            YouTubeService = new(
                new BaseClientService.Initializer()
                {
                    ApiKey = ApiDatabase.YouTube_API_KEY,
                    ApplicationName = "Randy The Referencer"
                }
            );
            IsYouTubeInitialized = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            IsYouTubeInitialized = false;
        }

        return IsYouTubeInitialized;
    }
}
