namespace Randy_The_Referencer;

public partial class frmRandy : Form
{
    public frmRandy()
    {
        InitializeComponent();
        Init();
    }

    private List<string> authors = new();

    private void Init()
    {
        pnlBook.Visible = false;

        cmbMediaTypes.Items.Add("Book");
    }

    private void cmbMediaTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cmbMediaTypes.SelectedIndex)
        {
            case 0:
                Book();
                break;

            default:
                break;
        }
    }

    private void Book()
    {
        pnlBook.Visible = true;
    }

    private void btnFormat_Click(object sender, EventArgs e)
    {
        BookFormat bookFormat =
            new(
                authors.ToArray(),
                (int)spnYear.Value,
                txtBookName.Text,
                (int)spnEdition.Value,
                txtPubPlace.Text,
                txtPubName.Text
            );

        redOutput.Clear();
        redOutput.Text = bookFormat.ToString();
    }

    private void btnAddAuthor_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAuthors.Text))
            return;

        authors.Add(txtAuthors.Text);
        txtAuthors.Text = "";
        redAuthors.Clear();
        for (int i = 0; i < authors.Count; i++)
            redAuthors.Text += i == 0 ? $"{authors[i]}" : $", {authors[i]}";
    }

    private void btnClearAuthors_Click(object sender, EventArgs e)
    {
        authors.Clear();
        redAuthors.Clear();
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetDataObject(redOutput.Text);
    }
}