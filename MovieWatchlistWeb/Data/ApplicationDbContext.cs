using Microsoft.EntityFrameworkCore;
using MovieWatchlistWeb.Models;

namespace MovieWatchlistWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
