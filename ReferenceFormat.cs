namespace Randy_The_Referencer;

public abstract class ReferenceFormat
{
    protected abstract string Format();

    public override string ToString() => Format();
}
