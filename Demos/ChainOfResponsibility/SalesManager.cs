namespace ChainOfResponsibility;

internal class SalesManager : Handler
{
    public override void Approve(Purchase purchase)
    {
        if (purchase == null) return;
        if (purchase?.TotalPrice < 2500)
        {
            Console.WriteLine($"Sales Manager approved the purchase of {purchase.Number} {purchase.Item} for a total of {purchase.TotalPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"{purchase?.TotalPrice.ToString("C")}: Sales Manager is not allowed to do this.");
            _next?.Approve(purchase!);
        }
    }
}
