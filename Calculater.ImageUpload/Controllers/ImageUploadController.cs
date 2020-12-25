using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculater.ImageUpload.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        [HttpGet("Upload")]
        public IActionResult Upload()
        {
            string fileName = Guid.NewGuid().ToString().Replace("-", "_") + ".png";
            var imageFile = new ImageFile { FileName = fileName };
            return Ok(imageFile);
        }
    }
}
