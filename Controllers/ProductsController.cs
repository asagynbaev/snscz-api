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
            var query = from p in _context.Products
                join img in _context.Images on p.Image.Id equals img.Id
                join volType in _context.VolumeTypes on p.VolumeType.Id equals volType.Id
                select new { Product = p, Image = img, VolumeType = volType };
                
            return Ok(query);
        }
    }
}