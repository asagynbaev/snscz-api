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
                join img in _context.Images on p.ImageId equals img.Id
                join volType in _context.VolumeTypes on p.VolumeTypeId equals volType.Id
                select new { Product = p, Image = img, VolumeType = volType };
                
            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct([FromBody]Products product)
        {
            try
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok(product);
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { message = "Error is" + ex.Message });
            }
        }
    }
}