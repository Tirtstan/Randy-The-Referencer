namespace Randy_The_Referencer;

public class FormatUserControl : UserControl
{
    public static event Action<string, string, string>? OnFormatButton;

    protected void FormatButton(string format, string paraphrased, string quote)
    {
        OnFormatButton?.Invoke(format, paraphrased, quote);
    }
}
