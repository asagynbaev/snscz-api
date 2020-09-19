using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snscz_api.Helpers;
using snscz_api.Models;

namespace snscz_api
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly SnsContext _context;
        public ProductsController(SnsContext context)
        {
            _context = context;
        }

        //[Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Products.ToList();
            return Ok(result);
        }
    }
}