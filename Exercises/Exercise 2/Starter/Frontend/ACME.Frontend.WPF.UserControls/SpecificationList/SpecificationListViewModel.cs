using ACME.DataLayer.Entities;
using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.ProductList;
using ACME.Frontend.WPF.UserControls.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ACME.Frontend.WPF.UserControls.SpecificationList;

public class SpecificationListViewModel : BaseViewModel
{
    private readonly IUnitOfWork _repositories;

    public SpecificationListViewModel(IUnitOfWork repositories)
    {
        _repositories = repositories;
    }
    public ObservableCollection<SpecificationViewModel> Specifications { get; private set; } = new ObservableCollection<SpecificationViewModel>();
    public async Task LoadSpecificationsAsync()
    {
        // TODO: product and productGroup should be retrieved from somewhere.
        // Current value are just temporary.
        ProductViewModel product = new ProductViewModel { Id = 1 };
        ProductGroupViewModel productGroup = new ProductGroupViewModel { Id = 2 };

        var defs = await _repositories.ProductGroups.GetSpecificationDefinitionsAsync(productGroup.Id);
        var specs = await _repositories.Products.GetSpecificationsAsync(product.Id);
        var specifications = specs.Join(defs, sp => sp.Key, sd => sd.Key, ConstructSpecification);

        foreach (var item in specifications)
        {
            Specifications.Add(item);
        }
    }

    private static SpecificationViewModel ConstructSpecification(Specification sp, SpecificationDefinition sd)
    {
        var spec = new SpecificationViewModel
        {
            Label = sd.Name,
            Info = sd.Description
        };
        if (sp.NumberValue != null)
        {
            spec.Value = $"{sp.NumberValue} {sd.Unit}";
        }
        if (sp.BoolValue != null)
        {
            spec.Value = $"{sp.BoolValue}";
        }
        if (sp.StringValue != null)
        {
            spec.Value = $"{sp.StringValue} {sd.Unit}";
        }
        return spec;
    }
}
