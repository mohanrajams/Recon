using Microsoft.AspNetCore.Mvc;
using Recon.Data.Models.Master;
using Recon.Data.Repositories;

namespace Recon.Api.Controllers
{

    [Route("/api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IMasterRepository<Product> _productRepository;

        public ProductController(IMasterRepository<Product> productRepository) 
        { 
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ICollection<Product>> Get()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}
