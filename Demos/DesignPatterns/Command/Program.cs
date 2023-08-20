namespace Command;

internal class Program
{
    static void Main(string[] args)
    {
        var app = new AppInvoker();
        do
        {
            char op = AskOperation();
            
            if (op == 'u')
            {
                app.Undo();
                Console.WriteLine(app.Value);
            }
            else
            {
                int nr = AskNumber();
                Console.Write($"{app.Value} {op} {nr} = ");
                app.Compute(op, nr);
                Console.WriteLine(app.Value);
            }
        }
        while (true);
    }

    private static int AskNumber()
    {
        do
        {
            Console.WriteLine("Give a number");
            var key = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(key, out var value)) return value;
        }
        while (true);
    }

    private static char AskOperation()
    {
        do
        {
            Console.WriteLine("What operation? (+, - or u (Undo))");
            var key = Console.ReadKey();
            Console.WriteLine();
            var sop = char.ToLower(key.KeyChar);
            if (sop == '+' || sop == '-' || sop == 'u') return sop;
        }
        while (true);
    }
}