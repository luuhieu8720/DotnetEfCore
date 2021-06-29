using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCore
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var sqlConnection = configuration.GetValue<string>("DbConfig:Connection");
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseSqlServer(sqlConnection);
            return new DataContext(optionsBuilder.Options);
        }
    }
}
