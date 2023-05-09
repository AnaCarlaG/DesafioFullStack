using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lojinha.Infra.MigrationsConfigurations
{
    public class DbFactoryContext : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseNpgsql("Server=localhost\\SQLEXPRESS;Database=Desafio;Trusted_Connection=True;");
            DBContext context = new DBContext(optionsBuilder.Options);

            return context;
        }
    }
}
