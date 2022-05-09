using DI_genericsTypes.Model;
using DI_genericsTypes.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DI_genericsTypes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IGenericRepository<Customers> _genericRepository;

        public CustomersController(IGenericRepository<Customers> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpPost]
        public ActionResult Post()
        {
            _genericRepository.ADD(new Customers() { CNPJ = "02.942.233/0001-39", Name = "Roberth Santos Gomes"});            
            return Ok();
        }
    }
}
