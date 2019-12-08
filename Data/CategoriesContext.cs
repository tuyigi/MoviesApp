using Microsoft.EntityFrameworkCore;

namespace MoviesApp.Data
{
    public class CategoriesContext: DbContext
    {
        public CategoriesContext(DbContextOptions<CategoriesContext> options) : base(options) { }
        public DbSet<Models.Category> Categories { get; set; }
    }
}