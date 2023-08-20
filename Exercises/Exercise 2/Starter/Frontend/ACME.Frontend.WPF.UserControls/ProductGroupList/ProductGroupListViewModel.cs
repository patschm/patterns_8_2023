using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.ViewModels;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ACME.Frontend.WPF.UserControls.ProductGroupList;

public class ProductGroupListViewModel : BaseViewModel
{
    private readonly IUnitOfWork _repositories;

    public ProductGroupListViewModel(IUnitOfWork repositories)
    {
        _repositories = repositories;
        SelectCommand = new RelayCommand<ProductGroupViewModel>(SelectItem);
    }

    private void SelectItem(ProductGroupViewModel? group)
    {
        if (group == null) return;
        // TODO: Navigate to  ProductListView
    }

    public ICommand SelectCommand { get; }
    public ObservableCollection<ProductGroupViewModel> ProductGroups { get; private set; } = new ObservableCollection<ProductGroupViewModel>();
    public async Task LoadProductGroupsAsync()
    {
        var repository = _repositories.ProductGroups;
        ProductGroups.Clear();
        var groups = await repository.GetAllAsync(1, 100);
        foreach(var item in groups.Select(pg=>new ProductGroupViewModel { Id = pg.Id, Name = pg.Name, Image = pg.Image }))
        {
            ProductGroups.Add(item);
        }
    }
}
