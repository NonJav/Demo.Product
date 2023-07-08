using DataContext.Entities;

namespace Person.Service.Repository;

//contract
public interface IProductRepository
{
    Task<List<Product>> GetProducts();
    Task<Product> Create(Product input);
    
    //Validaciones
    Task<bool> ExistProductByName(string name);
}