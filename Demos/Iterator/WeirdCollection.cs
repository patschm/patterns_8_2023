namespace Iterator;

internal class WeirdCollection<T> : IIterable<T>
{
    private T[] _values = new T[30];
    private int _index = 0;
    public T? this[int index]
    {
        get
        {
            if (index < _values.Length)
                return _values[index];
            return default;
        }
        set
        {
            Add(value);
        }
    }
    public int Count { get => _index+1; }
    public void Add(T? item)
    {
        if (item == null) return;
        if (_index >= _values.Length) 
        { 
            Array.Resize<T>(ref _values, _index + 30);
        }
        _values[_index++] = item;
    }
    public IIterator<T> GetIterator()
    {
        return new WeirdIterator<T>(this);
    }
}
