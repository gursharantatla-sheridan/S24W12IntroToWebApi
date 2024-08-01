using Microsoft.EntityFrameworkCore;

namespace S24W12IntroToWebApi
{
    public class BookContext : DbContext
    {
        // entity set
        // DbSet property
        public DbSet<Book> Books { get; set; }

        // constructor
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        // data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "HTML", Price = 10 },
                new Book { BookId = 2, Title = "ASP.NET", Price = 20 }
            );
        }
    }
}
