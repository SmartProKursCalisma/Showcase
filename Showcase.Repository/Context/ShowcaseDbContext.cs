using Microsoft.EntityFrameworkCore;
using Showcase.Core.Entities;

namespace Showcase.Repository.Context
{
    public class ShowcaseDbContext : DbContext
    {
        public ShowcaseDbContext(DbContextOptions<ShowcaseDbContext> opt):base(opt)
        {
            
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products{ get; set; }
    }
}
