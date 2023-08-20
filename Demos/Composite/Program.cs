using System.Security.Cryptography;

namespace Composite;

internal class Program
{
    static void Main(string[] args)
    {
        var c1 = new Composite();
        c1.Add(new Leaf());
        c1.Add(new Leaf());
        var c2 = new Composite();
        c2.Add(new Leaf());
        c2.Add(new Leaf());
        c1.Add(c2);

        var complete=new Composite();
        complete.Add(c1);
        complete.Add(c2);   
        complete.Show();
    }
}