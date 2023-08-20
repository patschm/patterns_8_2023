using ACME.DataLayer.Entities;
using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.Extensions;
using ACME.Frontend.WPF.UserControls.ProductList;
using ACME.Frontend.WPF.UserControls.ViewModels;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ACME.Frontend.WPF.UserControls.ReviewList;

public class ReviewListViewModel : BaseViewModel
{
    private readonly IUnitOfWork _repositories;

    public ReviewListViewModel(IUnitOfWork repositories)
    {
        _repositories = repositories;
        
        NewReview = new RelayCommand(ReviewEditor);
    }

   public ObservableCollection<ReviewViewModel> Reviews { get; private set; } = new ObservableCollection<ReviewViewModel>();
   public ICommand NewReview { get; }
    private void ReviewEditor()
    {
        // TODO: Navigate to ReviewDetailView
    }


    public async Task LoadReviewsAsync()
    {
        // TODO: product should be retrieved from somewhere. Current value is just
        // temporary.
        ProductViewModel product = new ProductViewModel { Id = 1 };

        Reviews.Clear();
        var t1 = await _repositories.Products.GetReviewsAsync<ExpertReview>(product.Id);
        var t2 = await _repositories.Products.GetReviewsAsync<ConsumerReview>(product.Id);
        var t3 = await _repositories.Products.GetReviewsAsync<WebReview>(product.Id);

        var reviews = ListHelper.Concatenate<Review>(t1, t2, t3);
        foreach (var item in reviews.Select(pr => new ReviewViewModel { Author=pr.Reviewer?.Name, Email=pr.Reviewer?.Email, Score=pr.Score, Text=pr.Text }))
        {
            Reviews.Add(item);
        }
    }
}
