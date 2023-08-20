namespace Bridge.Animals
{
    public class Zebra: Grazer
    {
        public override void MakeNoise()
        {
            Console.WriteLine("The zebra says OINK!");
        }
    }
}
