using Microsoft.EntityFrameworkCore;
using ASP.Net.Models.Bill;

namespace ASP.Net.DataAccess.Context
{
    public class BillContext : DbContext
    {
        public BillContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
