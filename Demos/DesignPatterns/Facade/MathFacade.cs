using Facade.Services;

namespace Facade;

internal class MathFacade
{
    private AddService _addService = new AddService();
    private SubtractService _subtractService = new SubtractService();

    public int Add(int a, int b)
    {
        return _addService.Add(a, b);
    }
    public int Subtract(int a, int b)
    {
        return (_subtractService.Subtract(a, b));
    }
    public int AddSubtract(int a, int b, int c)
    {
        var res = _addService.Add(a, b);
        return _subtractService.Subtract(res, c);
    }
}
