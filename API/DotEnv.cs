namespace Randy_The_Referencer;

public static class DotEnv // https://dusted.codes/dotenv-in-dotnet
{
    public static void Load(string filePath)
    {
        if (!File.Exists(filePath))
        {
            MessageBox.Show("No YouTube API Key set!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
                continue;

            Environment.SetEnvironmentVariable(parts[0], parts[1]);
        }
    }
}
