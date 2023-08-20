namespace Command;

internal class SubtractCommand : ICommand
{
    private readonly CaclulatorReceiver _receiver;
    public int Number { get; set; }

    public SubtractCommand(CaclulatorReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.SubtractFrom(Number);
    }

    public void Undo()
    {
        _receiver.SubtractFrom(-Number);
    }
}
