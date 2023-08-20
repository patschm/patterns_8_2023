namespace Iterator;

internal interface IIterable<T>
{
    IIterator<T> GetIterator();
}
