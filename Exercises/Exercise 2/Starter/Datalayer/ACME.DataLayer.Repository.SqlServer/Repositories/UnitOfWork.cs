using ACME.DataLayer.Interfaces;

namespace ACME.DataLayer.Repository.SqlServer;

public class UnitOfWork : IUnitOfWork
{
    private readonly ShopDatabaseContext _context;
    public UnitOfWork(ShopDatabaseContext context)
    {
        _context = context;
    }
    
    public IBrandRepository Brands { get => new BrandRepository(_context); }

    public IPriceRepository Prices { get => new PriceRepository(_context); }

    public IProductGroupRepository ProductGroups { get => new ProductGroupRepository(_context); }

    public IProductRepository Products { get => new ProductRepository(_context); }

    public IReviewRepository Reviews { get => new ReviewRepository(_context); }

    public ISpecificationRepository Specifications { get=> new SpecificationRepository(_context); }

    public ISpecificationDefinitionRepository SpecificationsDefinition { get=> new SpecificationDefinitionRepository(_context); }

    public IReviewerRepository Reviewers { get=> new ReviewerRepository(_context); }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
