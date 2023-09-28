using InfrastructureServices.Data.Map;
using InfrastructureServices.Model;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureServices.Data
{
    public class RequestSystemDBContext : DbContext
    {
        public RequestSystemDBContext(DbContextOptions<RequestSystemDBContext> options) 
            : base(options)
        {
        }

        public DbSet<RequestForPrinterInstallationModel> Requests { get; set; }
        //public DbSet<RequestForPrinterInstallationModel> Requests => Set<RequestForPrinterInstallationModel>();
        //public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequestForPrinterInstallationMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
