using Library.Modells;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace Library.DbContext
{
    public class LibraryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }



}
