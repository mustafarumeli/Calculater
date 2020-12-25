using System.Linq;
using Calculater.Database;
using Calculater.OCR.Methods;
using Microsoft.AspNetCore.Mvc;

namespace Calculater.OCR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcrController : ControllerBase
    {
        [HttpGet("OCR")]
        public IActionResult Get(string fileName)
        {
            var imageFile = DbFactory.ImageFiles.FirstOrDefault(x => x.FileName == fileName);
            if (imageFile == null)
            {
                return NotFound();
            }
            return Ok(ReadOCR.Read(imageFile));
        }
    }
}
