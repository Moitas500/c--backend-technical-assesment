using API_REST_C_.Models;
using Microsoft.EntityFrameworkCore;

namespace API_REST_C_.Context
{
    public class AppDbContext : DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

    }
}
