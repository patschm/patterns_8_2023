using ACME.DataLayer.Entities;
using ACME.DataLayer.Interfaces;
using ACME.Frontend.WPF.Core.Base;
using ACME.Frontend.WPF.UserControls.ProductList;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;

namespace ACME.Frontend.WPF.UserControls.ReviewDetail;

public class ReviewDetailViewModel: BaseViewModel
{    
    private readonly IUnitOfWork _repositories;
    private string? _author;
    private string? _text;
    private string? _email;
    private byte _score;
    private DateTime _dateBought;
    private ProductViewModel? _product;
    
    public ReviewDetailViewModel(IUnitOfWork repositories)
    {
        _repositories = repositories;
        SaveCommand = new RelayCommand(SaveDataAsync);
        CancelCommand = new RelayCommand(Cancel);
        BackCommand = new RelayCommand(Cancel);
    }
    
    public string? Author { get => _author; set { _author = value; ChangeProperty(); } }
    public string? Text { get => _text; set { _text = value; ChangeProperty(); } }
    public byte Score { get => _score; set { _score = value; ChangeProperty(); } }
    public string? Email { get => _email; set { _email = value; ChangeProperty(); } }
    public DateTime DateBought { get => _dateBought; set { _dateBought = value; ChangeProperty(); } }
    public ProductViewModel? Product { get => _product; set { _product = value; ChangeProperty(); } }
    
    public ICommand SaveCommand { get; }
    public ICommand CancelCommand { get; }
    public ICommand BackCommand { get; }

    private void Cancel()
    {
        // TODO: Navigate to ProductDetailView
    }

    private async void SaveDataAsync()
    {
        var review = new ConsumerReview { 
            ProductId = Product!.Id,
            DateBought = DateBought,
            Reviewer = new Reviewer { Email = Email, Name = Author, UserName=Email},
            Score = Score,
            Text = Text,
        };
        await _repositories.Reviews.InsertAsync(review);
        await _repositories.SaveAsync();
        Cancel();
    }
    public void LoadData()
    {
        // TODO: product should be retrieved from somewhere. Current value is just
        // temporary.
        Product = new ProductViewModel { Id = 1 };
    }
}
