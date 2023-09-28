using InfrastructureServices.Model;

namespace InfrastructureServices.Repositories.Interfaces
{
    public interface IRequestForPrinterInstallation
    {
        Task<List<RequestForPrinterInstallationModel>> FindAll();
        Task<RequestForPrinterInstallationModel> FindById(int id);
        Task<List<RequestForPrinterInstallationModel>> Add(RequestForPrinterInstallationModel requestModel);
        Task<List<RequestForPrinterInstallationModel>> Update(RequestForPrinterInstallationModel requestModel, int id);
        Task<List<RequestForPrinterInstallationModel>> Delete(int id);

    }
}
