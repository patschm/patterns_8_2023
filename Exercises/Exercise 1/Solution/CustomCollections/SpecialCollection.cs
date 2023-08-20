using System.Collections;

namespace CustomCollections;

public class SpecialCollection<T> : ICollection<T>
{
    private readonly int _initialSize;
    private T[] _items;

    #region Sort
    // TODO 1: Examine the code.
    // Below is an implementation of the quicksort alghorithm
    // Since it is impossible to know on what member of an element
    // to sort (e.g. FirstName, LastName, Age?) we created a virtual
    // method Compare. Derived classes can overwrite this method
    // to implement the correct Compare logic.
    // The problem with this solution is that a derived class (PeopleList)
    // is needed.
    // What Design pattern would you recommend? (Strategy)
    // Rewrite this code to according to your choice of design pattern
    public void Sort(IComparer<T> strategy)
    {
        var firstNull = Array.IndexOf(_items, null);
        if (firstNull < 0) firstNull = _items.Length;
        {
            var segment = new ArraySegment<T>(_items, 0, firstNull);
            SortArray(segment, 0, segment.Count - 1, strategy);
        }
    }
    private void SortArray(ArraySegment<T> segment, int lower, int higher, IComparer<T> strategy)
    {
        var left = lower;
        var right = higher;
        var pivot = segment[lower + (higher - lower) / 2];
        while (left <= right)
        {
            while (strategy.Compare(_items[left], pivot) < 0) left++;
            while (strategy.Compare(_items[right], pivot) > 0) right--;
            if (left <= right)
            {
                T tmp = _items[left];
                _items[left] = _items[right];
                _items[right] = tmp;
                left++;
                right--;
            }
        }
        if (lower < right) SortArray(segment, lower, right, strategy);
        if (left < higher) SortArray(segment, left, higher, strategy);
    }
    #endregion
    #region Constructors
    public SpecialCollection() : this(10) { }
    public SpecialCollection(int initalSize)
    {
        _initialSize = initalSize;
        _items = new T[_initialSize];
    }
    #endregion
    #region Operators
    public T? this[int idx]
    {
        get
        {
            if (idx >= 0 && idx < Count)
            {
                return _items[idx];
            }
            return default;
        }
        set
        {
            if (value != null && idx >= 0 && idx < _items.Length)
            {
                _items[idx] = value;
            }
        }
    }
    public static implicit operator SpecialCollection<T>(T[] array)
    {
        var collection = new SpecialCollection<T>(array.Length);
        for (var i = 0; i < array.Length; i++)
        {
            collection.Add(array[i]);
        }
        return collection;
    }
    #endregion
    #region ICollection
    public int Count => _items.Where(it => it != null).Count();
    public bool IsReadOnly => false;
    public void Add(T? item)
    {
        if (item == null) return;
        var index = 0;
        for (; index < _items.Length; index++)
        {
            if (_items[index] == null)
            {
                _items[index] = item;
                return;
            }
        }
        Array.Resize<T>(ref _items, _items.Length * 2);
        _items[index] = item;
    }
    public void Clear()
    {
        Array.Clear(_items);
        Array.Resize(ref _items, _initialSize);
    }
    public bool Contains(T item)
    {
        return _items.Contains(item);
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
        var j = 0;
        for (var i = arrayIndex; i < _items.Length; i++)
        {
            array[i] = _items[j++];
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return _items.AsEnumerable<T>().GetEnumerator();
    }
    public bool Remove(T? item)
    {
        if (item == null) return false;
        var idx = Array.IndexOf(_items, item);
        if (idx >= 0)
        {
            var before = new ArraySegment<T>(_items, 0, idx);
            var after = new ArraySegment<T>(_items, idx + 1, Count - idx - 1);
            _items = before.Concat(after).ToArray();
            return true;
        }
        return false;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _items.GetEnumerator();
    }
    #endregion
}
