using GenericRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
