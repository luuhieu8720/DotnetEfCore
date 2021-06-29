using DemoEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCore
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
