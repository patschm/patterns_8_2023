namespace ChainOfResponsibility;

internal class Sales : Handler
{
    public override void Approve(Purchase purchase)
    {
        if (purchase == null) return;
        if (purchase?.TotalPrice < 1000)
        {
            Console.WriteLine($"Sales approved the purchase of {purchase.Number} {purchase.Item} for a total of {purchase.TotalPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"{purchase?.TotalPrice.ToString("C")}: Sales is not allowed to do approve this.");
            _next?.Approve(purchase!);
        }
    }
}
