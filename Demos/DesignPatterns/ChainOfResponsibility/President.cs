namespace ChainOfResponsibility;

internal class President : Handler
{
    public override void Approve(Purchase purchase)
    {
        if (purchase == null) return;
        if (purchase?.TotalPrice < 10000)
        {
            Console.WriteLine($"President approved the purchase of {purchase.Number} {purchase.Item} for a total of {purchase.TotalPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"We need a meeting over this purchase: {purchase?.Number} {purchase?.Item} for a total of {purchase?.TotalPrice.ToString("C")}");
        }
    }
}
