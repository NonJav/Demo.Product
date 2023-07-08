using DataContext.Entities;
using Person.Service.Repository;

namespace Person.Service.Service;

public class ProductService : IProductService
{
    private IProductRepository _repository;
    
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<List<Product>> GetProducts()
    {
        return await _repository.GetProducts();
    }

    public async Task<Product> Create(Product input)
    {
        //Validar si el producto existe, antes de crearlo
        var productExist = await _repository.ExistProductByName(input.Name);
        if (productExist)
        {
            throw new ApplicationException("Ya existe este producto");
        }

        return await _repository.Create(input);
    }
}