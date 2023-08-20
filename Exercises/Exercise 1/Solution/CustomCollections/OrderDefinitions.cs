namespace CustomCollections;

public class OrderByFirstName : IComparer<Person>
{
    public int Compare(Person? left, Person? right)
    {
        if (left == null || right == null || left.FirstName == null) return 0;
        return left.FirstName.CompareTo(right.FirstName);
    }
}
public class OrderByLastName : IComparer<Person>
{
    public int Compare(Person? left, Person? right)
    {
        if (left == null || right == null || left.LastName == null) return 0;
        return left.LastName.CompareTo(right.LastName);
    }
}
public class OrderByAge : IComparer<Person>
{
    public int Compare(Person? left, Person? right)
    {
        if (left == null || right == null) return 0;
        return left.Age.CompareTo(right.Age);
    }
}
