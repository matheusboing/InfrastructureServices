using InfrastructureServices.Model;

namespace InfrastructureServices.Repositories.Interfaces
{
    public interface IRequestForPrinterInstallation
    {
        Task<List<RequestForPrinterInstallationModel>> FindAll();
        Task<RequestForPrinterInstallationModel> FindById(int id);
        Task<RequestForPrinterInstallationModel> Add(RequestForPrinterInstallationModel usuario);
        Task<RequestForPrinterInstallationModel> Update(RequestForPrinterInstallationModel usuario, int id);
        Task<bool> Delete(int id);

    }
}
