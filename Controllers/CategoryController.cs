using System.Linq;
using Microsoft.AspNetCore.Mvc;
using snscz_api.Helpers;

namespace snscz_api
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController: ControllerBase
    {
        private readonly SnsContext _context;
        public CategoryController(SnsContext context)
        {
            _context = context;
        }

        //[Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Categories.ToList();
            return Ok(result);
        }
    }
}