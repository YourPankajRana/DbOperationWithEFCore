using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) 
        {
        
        }
        public DbSet<Book> Books { get; set; }

        
    }
}
