using InfrastructureServices.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureServices.Data.Map
{
    public class RequestForPrinterInstallationMap : IEntityTypeConfiguration<RequestForPrinterInstallationModel>
    {
        public void Configure(EntityTypeBuilder<RequestForPrinterInstallationModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PrinterName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PrinterModel).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PersonResponsableForInstallation).IsRequired().HasMaxLength(255);
        }
    }
}
