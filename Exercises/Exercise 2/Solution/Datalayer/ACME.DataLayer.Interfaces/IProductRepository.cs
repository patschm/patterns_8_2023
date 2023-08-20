﻿using ACME.DataLayer.Entities;

namespace ACME.DataLayer.Interfaces;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Price>> GetPricesAsync(long productId, int page = 1, int count = 50);
    Task<IEnumerable<Specification>> GetSpecificationsAsync(long productId, int page = 1, int count = 50);
    Task<IEnumerable<TReview>> GetReviewsAsync<TReview>(long productId, int page = 1, int count = 50) where TReview : Review;
}
