namespace Randy_The_Referencer;

public static class Utilities
{
    public static string FormatFullName(string name)
    {
        string[] names = name.Split(" ");
        return $"{names[1]}, {names[0][..1]}.";
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
}
