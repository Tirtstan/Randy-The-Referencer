using System.Web;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace Randy_The_Referencer;

public static class YouTubeHelper
{
    public static bool IsYouTubeInitialized { get; private set; }
    public static YouTubeService YouTubeService { get; private set; }

    public static bool IsYouTubeLink(string link)
    {
        bool valid = false;
        try
        {
            string host = new Uri(link).Host.ToLower();
            valid = host == "youtube.com" || host == "youtu.be";
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

        var videoId = "";
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
        string key = Utilities.GetAPIKey("API_KEY");
        if (string.IsNullOrEmpty(key))
        {
            Console.WriteLine("API Key not found.");
            IsYouTubeInitialized = false;
            return IsYouTubeInitialized;
        }

        try
        {
            YouTubeService = new(new BaseClientService.Initializer() { ApiKey = key, ApplicationName = "Randy The Referencer" });
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
