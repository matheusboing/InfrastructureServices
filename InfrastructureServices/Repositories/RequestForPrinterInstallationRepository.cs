using InfrastructureServices.Data;
using InfrastructureServices.Model;
using InfrastructureServices.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureServices.Repositories
{
    public class RequestForPrinterInstallationRepository : IRequestForPrinterInstallation
    {
        private readonly RequestSystemDBContext _dbContext;
        public RequestForPrinterInstallationRepository(RequestSystemDBContext requestSystemDBContext) {
            _dbContext = requestSystemDBContext;
         }
        public async Task<RequestForPrinterInstallationModel> FindById(int id)
        {
            return await _dbContext.Requests.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<RequestForPrinterInstallationModel>> FindAll()
        {
            return await _dbContext.Requests.ToListAsync();
        }

        public async Task<List<RequestForPrinterInstallationModel>> Add(RequestForPrinterInstallationModel requestModel)
        {
            _dbContext.Requests.Add(requestModel);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Requests.ToListAsync();
        }

        public async Task<List<RequestForPrinterInstallationModel>> Update(RequestForPrinterInstallationModel requestModel, int id)
        {
            RequestForPrinterInstallationModel requestById = await FindById(id);

            if(requestById == null)
            {
                throw new Exception($"Requisição para o ID: {id} não foi localizado no banco de dados.");
            }

            requestById.PrinterName = requestModel.PrinterName;
            requestById.PrinterModel = requestModel.PrinterModel;
            requestById.Location = requestModel.Location;
            requestById.TypeOfConnection = requestModel.TypeOfConnection;
            requestById.PersonResponsableForInstallation = requestModel.PersonResponsableForInstallation;

            _dbContext.Requests.Update(requestById);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Requests.ToListAsync();
        }
        public async Task<List<RequestForPrinterInstallationModel>> Delete(int id)
        {
            RequestForPrinterInstallationModel requestById = await FindById(id);

            if (requestById == null)
            {
                throw new Exception($"Requisição para o ID: {id} não foi localizado no banco de dados.");
            }

            _dbContext.Remove(requestById);
            await _dbContext.SaveChangesAsync();
            return await _dbContext.Requests.ToListAsync();
        }

    }
}
