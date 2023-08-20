namespace Command;

internal class CaclulatorReceiver
{
    public int CurrentValue { get; set; }

    public void AddTo(int a)
    {
        CurrentValue += a;
    }
    public void SubtractFrom(int a)
    {
        CurrentValue -= a;
    }
}
