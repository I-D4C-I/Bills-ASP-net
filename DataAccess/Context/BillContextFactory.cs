using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ASP.Net.DataAccess.Context
{
    public class BillContextFactory : IDesignTimeDbContextFactory<BillContext>
    {
        public BillContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BillContext>();
            optionsBuilder.UseSqlite("Data Source=bills.db");

            return new BillContext(optionsBuilder.Options);
        }
    }
}
