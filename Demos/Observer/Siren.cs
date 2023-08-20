namespace ObserverNS
{
    internal class Siren : Observer
    {
        public override void Notify(string data)
        {
            Console.WriteLine($"Siren fired for {data}");
        }
    }
}