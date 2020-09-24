using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using snscz_api.Helpers;
using snscz_api.Models;

namespace snscz_api
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController: ControllerBase
    {
        private readonly SnsContext _context;
        public static IHostingEnvironment _environment;
        public ImagesController(SnsContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public class FIleUploadAPI
        {
            public IFormFile file { get; set; }
        }

        [HttpPost()]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
        {
            if (file != null)
            {
                if (file.Length > 0)
                {
                    Images img = new Images();
                    img.ImageTitle = file.FileName;
                    img.ImgGuid = Guid.NewGuid();
                    
                    using (var fs1 = file.OpenReadStream())
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        img.ImageData = ms1.ToArray();
                    }

                    _context.Add(img);
                    await _context.SaveChangesAsync();
                    return Ok(img); 
                }
                else
                    return BadRequest(new { message = "File size is 0" });
            }
            else
                return BadRequest(new { message = "Empty file" });
        }
    }
}