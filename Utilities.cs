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

    public static string GetAPIKey(string name)
    {
        string? root = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
        if (string.IsNullOrEmpty(root))
            return "";

        string dotenv = Path.Combine(root, "API", ".env");
        DotEnv.Load(dotenv);

        string? key = Environment.GetEnvironmentVariable(name);
        if (string.IsNullOrEmpty(key))
            return "";

        return key;
    }
}
