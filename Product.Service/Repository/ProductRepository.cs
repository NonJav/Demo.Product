using DataContext;
using DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Person.Service.Repository;

public class ProductRepository : IProductRepository
{
    private ContextRef _context;
    
    public ProductRepository(ContextRef context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProducts()
    {
        var response = await _context.Products.ToListAsync();
        return response;
    }

    public async Task<Product> Create(Product input)
    {
        input.CreatedDate = DateTime.Now;
        var result = await _context.Products.AddAsync(input);
        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> ExistProductByName(string name)
    {
        return await _context.Products.AnyAsync(product => product.Name.Equals(name));
    }
}