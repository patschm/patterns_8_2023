using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.ProductList;
using ACME.Frontend.WPF.UserControls.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ACME.Frontend.WPF.UserControls.PriceList;

public class PriceListViewModel : BaseViewModel
{
    private readonly IUnitOfWork _repositories;

    public PriceListViewModel(IUnitOfWork repositories)
    {
        _repositories = repositories;
    }
    public ObservableCollection<PriceViewModel> Prices { get; private set; } = new ObservableCollection<PriceViewModel>();
    public async Task LoadPricesAsync()
    {
        var repository = _repositories.Products;
        // TODO: product should be retrieved from somewhere. Current value is just
        // temporary.
        ProductViewModel product = new ProductViewModel { Id = 1 };
        Prices.Clear();
        var prices = await repository.GetPricesAsync(product.Id);
        foreach (var item in prices.Select(pr => new PriceViewModel { BasePrice = pr.BasePrice, PriceDate=pr.PriceDate, ShopName=pr.ShopName }))
        {
            Prices.Add(item);
        }
    }
}
