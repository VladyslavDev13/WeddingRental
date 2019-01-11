using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Persistence;
using Data.Views;
using Entities;

namespace Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<ProductCatalogView>> GetProductCatalogViewsAsync();
        Task AddNewProductAsync(Product newProduct);
    }
}