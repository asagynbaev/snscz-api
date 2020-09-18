using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snscz_api.Helpers;
using snscz_api.Models;

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

        [HttpPost]
        public async Task<IActionResult> SaveEmployer([FromBody]Categories category)
        {
            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return Ok(category);
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { message = "Error is" + ex.Message });
            }
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var categories = await _context.Categories.FindAsync(id);
                if (categories == null)
                {
                    return NotFound();
                }

                _context.Categories.Remove(categories);
                await _context.SaveChangesAsync();
                return new NoContentResult();
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { message = "Error is" + ex.Message });
            }
        }
    }
}