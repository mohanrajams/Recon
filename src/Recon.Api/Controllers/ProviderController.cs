using Microsoft.AspNetCore.Mvc;
using Recon.Data.Models.Master;
using Recon.Data.Repositories;

namespace Recon.Api.Controllers
{
    [Route("/api/provider")]
    public class ProviderController : ControllerBase
    {
        private readonly IMasterRepository<Provider> _providerRepository;

        public ProviderController(IMasterRepository<Provider> providerRepository)
        {
            _providerRepository = providerRepository;
        }

        [HttpGet]
        public async Task<ICollection<Provider>> Get()
        {
            return await _providerRepository.GetAllAsync();
        }
    }
}
