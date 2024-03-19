namespace Randy_The_Referencer;

public static class Utilities
{
    public static string FormatFullName(string name)
    {
        string[] names = name.Split(" ");
        return $"{names[1]}, {names[0][..1]}.";
    }

    public static string GetSurname(string name)
    {
        string[] names = name.Split(" ");
        return names[1];
    }

    public static string ListNames(string[] names, string endingWith)
    {
        string output = "";
        for (int i = 0; i < names.Length; i++)
        {
            if (i == 0)
            {
                output += $"{names[i]}";
            }
            else if (i == names.Length - 1)
            {
                output += $" {endingWith} {names[i]}";
            }
            else
            {
                output += $", {names[i]}";
            }
        }

        return output;
    }

    public static string AddOrdinal(this int num)
    {
        string number = num.ToString();
        if (number.EndsWith("11"))
            return number + "th";
        if (number.EndsWith("12"))
            return number + "th";
        if (number.EndsWith("13"))
            return number + "th";
        if (number.EndsWith("1"))
            return number + "st";
        if (number.EndsWith("2"))
            return number + "nd";
        if (number.EndsWith("3"))
            return number + "rd";
        return number + "th";
    }

    public static bool AreNullOrEmpty(params string[] strings)
    {
        bool valid = false;
        foreach (var text in strings)
        {
            if (string.IsNullOrEmpty(text))
                return true;
        }

        return valid;
    }
}
