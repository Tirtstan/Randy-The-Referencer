using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace Randy_The_Referencer;

public partial class ucYouTube : FormatUserControl
{
    private string previousLink = "";

    public ucYouTube()
    {
        InitializeComponent();
        dtpAccessedWhen.Value = DateTime.Now;
    }

    private void btnFormat_Click(object sender, EventArgs e)
    {
        YouTubeFormat youTubeFormat =
            new(txtTitle.Text, (int)spnYear.Value, txtChannel.Text, txtLink.Text, dtpAccessedWhen.Value);

        FormatButton(youTubeFormat.ToString(), youTubeFormat.GetParaphrased(), youTubeFormat.GetQuote());
    }

    private void btnFillInformation_Click(object sender, EventArgs e)
    {
        if (previousLink == txtLink.Text)
            return;

        if (string.IsNullOrWhiteSpace(txtLink.Text) || !YouTubeHelper.IsYouTubeLink(txtLink.Text))
        {
            MessageBox.Show("Not a valid YouTube link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!YouTubeHelper.IsYouTubeInitialized)
        {
            bool success = YouTubeHelper.InitializeYouTubeAPI();
            if (!success)
            {
                MessageBox.Show(
                    "Can't connect to the YouTube API, try again later...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        FillInformation();
    }

    private void FillInformation()
    {
        string? videoId = YouTubeHelper.GetVideoId(txtLink.Text);
        try
        {
            VideosResource.ListRequest listRequest = YouTubeHelper.YouTubeService.Videos.List("snippet");
            listRequest.Id = videoId;
            VideoListResponse response = listRequest.Execute();

            txtTitle.Text = response.Items[0].Snippet.Title;
            txtChannel.Text = response.Items[0].Snippet.ChannelTitle;
            spnYear.Value = response.Items[0].Snippet.PublishedAtDateTimeOffset.Value.Date.Year;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show("Failed to find video, check link again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        previousLink = txtLink.Text;
    }
}
