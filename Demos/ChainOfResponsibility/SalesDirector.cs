namespace ChainOfResponsibility;

internal class SalesDirector : Handler
{
    public override void Approve(Purchase purchase)
    {
        if (purchase == null) return;
        if (purchase?.TotalPrice < 5000)
        {
            Console.WriteLine($"Sales Director approved the purchase of {purchase.Number} {purchase.Item} for a total of {purchase.TotalPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"{purchase?.TotalPrice.ToString("C")}: Sales Director is not allowed to do this.");
            _next?.Approve(purchase!);
        }
    }
}
