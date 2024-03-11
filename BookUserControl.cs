namespace Randy_The_Referencer;

public partial class ucBook : FormatUserControl
{
    private List<string> authors = new();

    public ucBook()
    {
        InitializeComponent();
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

        FormatButton(bookFormat.ToString());
    }
}
