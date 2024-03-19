namespace Randy_The_Referencer;

public class BookFormat : ReferenceFormat
{
    public BookFormat(string[] authors, int year, string bookName, int editionNum, string pubPlace, string pubName)
    {
        Authors = authors;
        Year = year;
        BookName = bookName;
        EditionNum = editionNum;
        PubPlace = pubPlace;
        PubName = pubName;
    }

    public int Year { get; }
    public string BookName { get; }
    public int EditionNum { get; }
    public string PubPlace { get; }
    public string PubName { get; }
    public string[] Authors { get; }
    public string Paraphrased { get; private set; }

    protected override string Format()
    {
        string formattedAuthors = "";
        for (int i = 0; i < Authors.Length; i++)
        {
            string formattedName = Utilities.FormatFullName(Authors[i]);
            if (i == 0)
            {
                formattedAuthors += $"{formattedName}";
            }
            else if (i == Authors.Length - 1)
            {
                formattedAuthors += $" and {formattedName}";
            }
            else
            {
                formattedAuthors += $", {formattedName}";
            }
        }

        string edition = EditionNum > 1 ? $" {EditionNum.AddOrdinal()} ed. " : "";
        return $"{formattedAuthors} {Year}. *{BookName}*.{edition} {PubPlace}: {PubName}.";
    }

    public override string GetParaphrased()
    {
        string output;
        string[] surnames = new string[Authors.Length];
        for (int i = 0; i < surnames.Length; i++)
            surnames[i] = Utilities.GetSurname(Authors[i]);

        if (Authors.Length == 1)
        {
            output = $"{surnames[0]} ({Year}) argues...\nOR\n... ({surnames[0]}, {Year}).";
        }
        else if (Authors.Length >= 2)
        {
            output = "For first use...\n";
            output += $"{Utilities.ListNames(surnames, "and")} ({Year}) assert...\nOR\n";
            output += $"...({Utilities.ListNames(surnames, "&")}, {Year})";

            output += "\n\nFor after first use...\n";
            output += $"{surnames[0]} et al. ({Year}) argues...\nOR\n";
            output += $"({surnames[0]} et al., {Year})";
        }
        else
        {
            output = "";
        }

        return output;
    }

    public override string GetQuote()
    {
        string output;
        string[] surnames = new string[Authors.Length];
        for (int i = 0; i < surnames.Length; i++)
            surnames[i] = Utilities.GetSurname(Authors[i]);

        if (Authors.Length == 1)
        {
            output = $"According to {surnames[0]} ({Year}: page num)\nOR\n... ({surnames[0]}, {Year}: page num).";
        }
        else if (Authors.Length >= 2)
        {
            output = "For first use...\n";
            output += $"{Utilities.ListNames(surnames, "and")} ({Year}: page num)\nOR\n";
            output += $"...({Utilities.ListNames(surnames, "&")}, {Year}: page num)";

            output += "\n\nFor after first use...\n";
            output += $"{surnames[0]} et al. ({Year}: page num) argues...\nOR\n";
            output += $"({surnames[0]} et al., {Year}: page num)";
        }
        else
        {
            output = "";
        }

        return output;
    }
}
