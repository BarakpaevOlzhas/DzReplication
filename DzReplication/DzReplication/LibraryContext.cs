namespace DzReplication
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }
        
        public DbSet<Book> Books { set; get; }
        public  DbSet<Person> People { set; get; }
    }
 
}