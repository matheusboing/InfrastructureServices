namespace InfrastructureServices.Model
{
    public class RequestForPrinterInstallationModel
    {
        public int Id { get; set; }

        public string? PrinterName { get; set; }

        public string? PrinterModel { get; set; }

        public string? Location { get; set; }

        public string? TypeOfConnection { get; set; }

        public string? PersonResponsableForInstallation { get; set; }

        public DateTime? InstallationDate { get; set; }
    }
}
