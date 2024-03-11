namespace Randy_The_Referencer;

public partial class frmRandy : Form
{
    private UserControl[] userControls;

    public frmRandy()
    {
        InitializeComponent();
        Init();
    }

    private void Init()
    {
        FormatUserControl.OnFormatButton += OnFormatButton;

        userControls = [ucBook];
        HideAllUserControls();

        cmbMediaTypes.Items.Add("Book");
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