using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityCrud.Models
{
    public class LibraryDBContext:DbContext
    {
        public LibraryDBContext():base("LibraryDBContext")
            {
            }
        public DbSet<Book> Books { get; set; }
    }
}