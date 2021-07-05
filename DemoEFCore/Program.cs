using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DemoEFCore
{
    class Program
    {
        static void SampleInsert()
        {
            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);
            dbContext.Authors.Add(new Models.Author()
            {
                Birthday = new DateTime(1990, 1, 1),
                Name = "Tom",
            });

            dbContext.SaveChanges();
        }

        static void SampleUpdate()
        {

            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);
            var author = dbContext.Authors.FirstOrDefault(x => x.Id == 1);
            author.Name = "Yerry";

            dbContext.SaveChanges();
        }

        static void SampleDelete()
        {

            using var dbContext = new DataContextFactory().CreateDbContext(new string[0]);
            var author = dbContext.Authors.FirstOrDefault(x => x.Id == 1);
            dbContext.Authors.Remove(author);

            dbContext.SaveChanges();
        }
        static void Main(string[] args)
        {
            SampleInsert();
        }
    }
}
