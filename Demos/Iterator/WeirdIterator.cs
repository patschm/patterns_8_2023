namespace Iterator;

internal class WeirdIterator<T>: IIterator<T>
{
    private readonly WeirdCollection<T> _aggregate;
    private int index = 0;

    public WeirdIterator(WeirdCollection<T> values)
    {
        _aggregate = values;
    }

    public T? CurrentValue { get; set; }

    public void Reset()
    {
        index = 0;
    }

    public bool Next()
    {
        if (index<_aggregate.Count) 
        {
            CurrentValue = _aggregate[index++];
        }
        return index < _aggregate.Count;
    }
}
