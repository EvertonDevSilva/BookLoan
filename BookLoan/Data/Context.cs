using BookLoan.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLoan.Data
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<BookEntity> Books { get; set; }
    }
}
