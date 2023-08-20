using System.Collections;

namespace Strategy;

internal class IntCollection : IEnumerable<int>
{
    private int?[] _values = new int?[10];
    public int this[int idx]
    {
        get
        {
            if (idx < _values.Length && _values[idx].HasValue) 
                return _values[idx]!.Value;
            return 0;
        }
        set
        {
            for(var i =0; i < _values.Length; i++)
            {
                if (!_values[i].HasValue)
                {
                    _values[i] = value;
                    return;
                }
            }
        }
    }
    public void Add(int a)
    {
        var nextPosition = _values.Where(x => x.HasValue).Count();
        if (nextPosition >= _values.Length)
        {
            Array.Resize(ref _values, _values.Length+10);
        }
        _values[nextPosition] = a;
    }
    public void Sort(IStrategy sort)
    {
        sort.Sort(_values);
    }
    public IEnumerator<int> GetEnumerator()
    {
        return _values.Where(x=>x.HasValue).Cast<int>().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
