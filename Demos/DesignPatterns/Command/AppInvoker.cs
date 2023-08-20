namespace Command;

internal class AppInvoker
{
    private readonly Stack<ICommand> _commands = new Stack<ICommand>();
    private readonly CaclulatorReceiver _receiver = new CaclulatorReceiver();
    public int Value { get => _receiver.CurrentValue;set=>_receiver.CurrentValue = value; } 
    
    public void Compute(char @operation, int number)
    {
        switch(@operation)
        {
            case '+':
                {
                    var cmd = new AddCommand(_receiver) { Number = number };
                    cmd.Execute();
                    _commands.Push(cmd);
                    break;
                }
            case '-':
                {
                    var cmd = new SubtractCommand(_receiver) { Number = number };
                    cmd.Execute();
                    _commands.Push(cmd);
                    break;
                }
        }
    }
    public void Undo()
    {
        var cmd = _commands.Pop();
        cmd.Undo();
    }
}
