using System.Data;

namespace Memento;

// The Caretaker
internal class HyperV
{
    private Dictionary<DateTime, VirtualMachine.SnapShot> _snapShots = new Dictionary<DateTime, VirtualMachine.SnapShot>();
    private VirtualMachine _machine = new VirtualMachine();
    public VirtualMachine StartVM()
    {
        return _machine;
    }
    public void CreateSnapShot()
    {
        var ss = _machine.CreateSnapShot();
        _snapShots.Add(DateTime.Now, ss);
    }
    public void ShowSnapShots()
    {
        Console.WriteLine("We have the following snapshots:");
        int i = 1;
        foreach (var item in _snapShots)
        {
            Console.WriteLine($"{i++}) {item.Key}");
        }
    }
    public VirtualMachine RestoreSnapShot(int idx)
    {
        int i = 1;
        foreach (var item in _snapShots)
        {
            if (i++ == idx) 
            {
                _machine.RestoreSnapShot(item.Value);
                return _machine;
            }
        }
        return _machine;
    }
}
