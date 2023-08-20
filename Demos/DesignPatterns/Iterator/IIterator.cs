namespace Iterator;

internal interface IIterator<T>
{
    T CurrentValue { get; set; }
    bool Next();
    void Reset();
}
