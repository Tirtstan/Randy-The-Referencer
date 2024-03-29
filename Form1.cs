namespace Randy_The_Referencer;

public partial class frmRandy : Form
{
    private UserControl[] userControls;

    public frmRandy()
    {
        InitializeComponent();

        FormatUserControl.OnFormatButton += OnFormatButton;

        userControls = [ucBook, ucYouTube];
        HideAllUserControls();

        cmbMediaTypes.Items.Add("Book");
        cmbMediaTypes.Items.Add("YouTube");
        cmbMediaTypes.SelectedIndex = 0;
    }

    private void HideAllUserControls()
    {
        for (int i = 0; i < userControls.Length; i++)
            userControls[i].Visible = false;
    }

    private void cmbMediaTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        HideAllUserControls();
        userControls[cmbMediaTypes.SelectedIndex].Visible = true;
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(redOutput.Text))
            Clipboard.SetDataObject(redOutput.Text);
    }

    private void OnFormatButton(string format, string paraphrased, string quote)
    {
        redOutput.Text = format;
        redInfo.Text = $"In-Text Paraphrase:\n\n{paraphrased}\n\nIn-Text Quote:\n\n{quote}";
    }

    ~frmRandy()
    {
        FormatUserControl.OnFormatButton -= OnFormatButton;
    }
}