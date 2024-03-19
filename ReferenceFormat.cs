namespace Randy_The_Referencer;

public abstract class ReferenceFormat
{
    protected abstract string Format();
    public abstract string GetParaphrased();
    public abstract string GetQuote();

    public override string ToString() => Format();
}
