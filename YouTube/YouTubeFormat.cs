using Randy_The_Referencer;

public class YouTubeFormat : ReferenceFormat
{
    public YouTubeFormat(string title, int year, string channel, string link, DateTime accessedWhen)
    {
        Title = title;
        Year = year;
        Channel = channel;
        Link = link;
        AccessedWhen = accessedWhen;
    }

    public string Title { get; }
    public int Year { get; }
    public string Channel { get; }
    public string Link { get; }
    public DateTime AccessedWhen { get; }

    protected override string Format() =>
        $"*{Title}*. {Year}. YouTube video, added by {Channel}. [Online]. Available at: {Link} [Accessed {AccessedWhen:dd MMMM yyy}]";
}
