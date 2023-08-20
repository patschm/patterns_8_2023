namespace Builder;

internal interface IBuilder<T> where T: class, new()
{
    string? Color { get; set; }  
    void Create();
    void AddSeats();
    void AddEngine();
    void AddWheels();
    T? Result { get; }
}
