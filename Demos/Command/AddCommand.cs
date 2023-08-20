namespace Command;

internal class AddCommand : ICommand
{
    private readonly CaclulatorReceiver _receiver;
    public int Number { get; set; }

    public AddCommand(CaclulatorReceiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.AddTo(Number);
    }

    public void Undo()
    {
        _receiver.AddTo(-Number);
    }
}
