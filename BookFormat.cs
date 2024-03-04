namespace Randy_The_Referencer;

public class BookFormat : ReferenceFormat
{
    public BookFormat(
        string[] authors,
        int year,
        string bookName,
        int editionNum,
        string pubPlace,
        string pubName
    )
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

    public override string ToString()
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

        string edition = EditionNum > 1 ? $"{EditionNum.AddOrdinal()} ed. " : "";
        return $"{formattedAuthors} {Year}. *{BookName}*.{edition} {PubPlace}: {PubName}.";
    }
}
