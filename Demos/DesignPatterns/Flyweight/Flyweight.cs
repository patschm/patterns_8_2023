namespace Flyweight;

// Flyweight
internal class Flyweight
{
    public byte[]? Logo { get; set; }
    public string? LogoUrl { get; set; }

    public virtual void Download()
    {
        Console.WriteLine($"Downloading from {LogoUrl}");
        Logo = new byte[10000];
    }
}
