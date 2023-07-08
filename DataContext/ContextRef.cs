using DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataContext;

public class ContextRef : DbContext
{
    public DbSet<Product> Products { get; set; }
}