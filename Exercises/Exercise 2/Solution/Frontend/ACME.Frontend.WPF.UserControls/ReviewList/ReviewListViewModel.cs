using ACME.DataLayer.Entities;
using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.Core.Interfaces;
using ACME.Frontend.WPF.UserControls.Extensions;
using ACME.Frontend.WPF.UserControls.ProductList;
using ACME.Frontend.WPF.UserControls.ReviewDetail;
using ACME.Frontend.WPF.UserControls.ViewModels;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ACME.Frontend.WPF.UserControls.ReviewList;

public class ReviewListViewModel : BaseViewModel
{
    private readonly IUnitOfWork _repositories;
    private readonly IViewMediator _viewMediator;

    public ReviewListViewModel(IUnitOfWork repositories, IViewMediator viewMediator)
    {
        _repositories = repositories;
        _viewMediator = viewMediator;
        NewReview = new RelayCommand(ReviewEditor);
    }

   public ObservableCollection<ReviewViewModel> Reviews { get; private set; } = new ObservableCollection<ReviewViewModel>();
   public ICommand NewReview { get; }
    private void ReviewEditor()
    {
        _viewMediator.Activate<ReviewDetailView>();
    }


    public async Task LoadReviewsAsync()
    {
        ProductViewModel product = _viewMediator.DataBag.Product;
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
