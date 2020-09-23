using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using snscz_api.Helpers;

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
        public async Task<string> UploadFile([FromForm] IFormFile file)
        {
            string fName = file.FileName;
            string path = Path.Combine(_environment.ContentRootPath, "Images/" + file.FileName);
            
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return file.FileName; 
        }
    }
}