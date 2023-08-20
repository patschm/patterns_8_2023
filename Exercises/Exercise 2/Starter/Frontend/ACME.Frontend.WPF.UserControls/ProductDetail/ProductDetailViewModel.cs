using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.PriceList;
using ACME.Frontend.WPF.UserControls.ProductList;
using ACME.Frontend.WPF.UserControls.ReviewList;
using ACME.Frontend.WPF.UserControls.SpecificationList;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ACME.Frontend.WPF.UserControls.ProductDetail;

public class ProductDetailViewModel : BaseViewModel
{
	private ProductViewModel? _product;
	private readonly ReviewListViewModel _reviews;
	private readonly PriceListViewModel _prices;
	private readonly SpecificationListViewModel _specifications;
	private readonly IUnitOfWork _uow;

	public ProductDetailViewModel(IUnitOfWork uow, ReviewListViewModel reviews, PriceListViewModel prices, SpecificationListViewModel specifications)
	{
		_uow = uow;
		_reviews = reviews;
		_prices = prices;
		_specifications = specifications;
        BackCommand = new RelayCommand(NavigateBack);
    }

	public ICommand BackCommand { get; }

    public SpecificationListViewModel Specifications { get => _specifications; }
	public PriceListViewModel	Prices { 	get => _prices; }
	public ReviewListViewModel Reviews {	get => _reviews; }
	public ProductViewModel? Product
	{
		get { return _product; }
		set 
		{ 
			_product = value;
			ChangeProperty();
		}
	}

    public SpecificationListView? SpecificationView { get => new SpecificationListView(Specifications!); }
    public PriceListView? PriceView { get => new PriceListView(Prices!); }
    public ReviewListView? ReviewView { get =>new ReviewListView(Reviews!); }

    private void NavigateBack()
    {
        // TODO: Navigate to ProductListView
    }
	public async Task LoadDataAsync()
	{
		// TODO: Product should be retrieved from somewhere. Current value is just
		// temporary.
		Product = new ProductViewModel { Id = 1 };
		await Specifications.LoadSpecificationsAsync();
	}

}
