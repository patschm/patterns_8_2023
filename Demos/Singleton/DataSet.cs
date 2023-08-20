namespace Singleton;

internal class DataSet
{
    private DataSet()
    {
    }
    private static DataSet? _instance = null;
    public static DataSet Instance
    {
        get
        {
            if (_instance == null) _instance = new DataSet();
            return _instance;
        }
    }

    private int _counter = 0;
    public int Counter { get => _counter; }
    public void Increment()
    {
        _counter++;
    }
}
