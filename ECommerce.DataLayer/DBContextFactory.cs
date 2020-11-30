using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataLayer
{
    public class DBContextFactory : IDesignTimeDbContextFactory<EFDBContext>

    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Data Source=ARM1;Integrated Security=True;Database=Identety;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("ECommerce.DataLayer"));
            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
