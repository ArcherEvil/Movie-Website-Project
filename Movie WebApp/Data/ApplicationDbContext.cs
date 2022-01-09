using Microsoft.EntityFrameworkCore;
using Movie_WebApp.Models;

namespace Movie_WebApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movies> Movies { get; set; }
    }
}
