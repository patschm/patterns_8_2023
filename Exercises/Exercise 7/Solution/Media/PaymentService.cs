namespace Media;

public class PaymentService
{
    private Dictionary<string, string> users = new Dictionary<string, string>();
    private JwtTokenIssuer issuer = new JwtTokenIssuer();

    public bool CheckAccess(string? jwtToken, string? user, string? item)
    {
        if (jwtToken == null || user == null || item == null) return false;
        return issuer.Validate(jwtToken, user, item);   
    }
    public string? RequestAccess(string? user, string? itemId)
    {
        if (user == null || itemId == null) return "";
        if (!users.ContainsKey(user)) 
        {
            Console.WriteLine("You're not registered");
            return null;
        }
        Console.WriteLine($"Paying for {itemId}");
        return issuer.Create(user, itemId);
    }

    public bool Login(string? user)
    {
        if (user == null) return false;
        if (users.ContainsKey(user))
        {
            Console.WriteLine($"Welcome {user}");
            return true;
        }
        Console.WriteLine("User does not exist exists");
        return false;
    }
    public bool Register(string? user, string? creditCard)
    {
        if (user == null || creditCard == null) return false;
        if (!users.ContainsKey(user))
        {
            users.Add(user, creditCard);
            return true;
        }
        Console.WriteLine("User already exists");
        return false;
    }
    public bool Unregister(string? user) 
    {
        if (user == null || !users.ContainsKey(user)) return false;
        users.Remove(user);
        return true;
    }
}
