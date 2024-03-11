namespace Randy_The_Referencer;

public class FormatUserControl : UserControl
{
    public static event Action<string>? OnFormatButton;

    protected void FormatButton(string output)
    {
        OnFormatButton?.Invoke(output);
    }
}
