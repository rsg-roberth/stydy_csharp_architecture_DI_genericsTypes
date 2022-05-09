using DI_genericsTypes.Model;
using DI_genericsTypes.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DI_genericsTypes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _genericRepository;

        public ProductsController(IGenericRepository<Product> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpPost]
        public ActionResult Post()
        {
            _genericRepository.ADD(new Product() { Name = "Monitor UltraWide 29'", Price = 1000.87m});
            return Ok();
        }
    }
}
