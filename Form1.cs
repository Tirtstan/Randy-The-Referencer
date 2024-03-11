namespace Randy_The_Referencer;

public partial class frmRandy : Form
{
    public frmRandy()
    {
        InitializeComponent();
        Init();
    }

    private void Init()
    {
        FormatUserControl.OnFormatButton += OnFormatButton;

        ucBook.Visible = false;
        cmbMediaTypes.Items.Add("Book");
    }

    private void cmbMediaTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cmbMediaTypes.SelectedIndex)
        {
            case 0:
                ucBook.Visible = true;
                break;

            default:
                break;
        }
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(redOutput.Text))
            Clipboard.SetDataObject(redOutput.Text);
    }

    private void OnFormatButton(string output)
    {
        redOutput.Clear();
        redOutput.Text = output;
    }

    ~frmRandy()
    {
        FormatUserControl.OnFormatButton -= OnFormatButton;
    }
}
