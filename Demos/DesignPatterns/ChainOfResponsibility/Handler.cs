namespace ChainOfResponsibility;

internal abstract class Handler
{
    protected Handler? _next = null;

    public void Next(Handler handler)
    {
        _next = handler;
    }
    public abstract void Approve(Purchase purchase);
}
