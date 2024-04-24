using Microsoft.EntityFrameworkCore;

namespace Mvcapp.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Product> Product { get; set; }
    }
}