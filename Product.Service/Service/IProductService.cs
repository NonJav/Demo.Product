using DataContext.Entities;

namespace Person.Service.Service;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<Product> Create(Product input);
}