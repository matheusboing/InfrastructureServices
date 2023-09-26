using InfrastructureServices.Model;
using InfrastructureServices.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfrastructureServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestForPrinterInstallationController : ControllerBase
    {
        private readonly IRequestForPrinterInstallation _requestForPrinterInstallationRepository;

        public RequestForPrinterInstallationController(IRequestForPrinterInstallation requestForPrinterInstallationRepository)
        {
            _requestForPrinterInstallationRepository = requestForPrinterInstallationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<RequestForPrinterInstallationModel>>> FindAllPrinterRequests()
        {
            List<RequestForPrinterInstallationModel> requests = await _requestForPrinterInstallationRepository.FindAll();
            return Ok(requests);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RequestForPrinterInstallationModel>> FindPrinterRequestById(int id)
        {
            RequestForPrinterInstallationModel request = await _requestForPrinterInstallationRepository.FindById(id);
            return Ok(request);
        }

        [HttpPost]
        public async Task<ActionResult<RequestForPrinterInstallationModel>> AddPrinterRequests([FromBody] RequestForPrinterInstallationModel requestsModel)
        {
            RequestForPrinterInstallationModel request = await _requestForPrinterInstallationRepository.Add(requestsModel);
            return Ok(request);
        }

        [HttpPut]
        public async Task<ActionResult<RequestForPrinterInstallationModel>> UpdatePrinterRequest([FromBody] RequestForPrinterInstallationModel requestModel, int id)
        {
            requestModel.Id = id;
            RequestForPrinterInstallationModel request = await _requestForPrinterInstallationRepository.Update(requestModel, id);
            return Ok(request);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<RequestForPrinterInstallationModel>> Delete(int id)
        {
            bool deleted = await _requestForPrinterInstallationRepository.Delete(id);
            return Ok(deleted);
        }

    }
}
