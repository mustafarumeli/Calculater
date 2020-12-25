using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            string fileName = Guid.NewGuid().ToString().Replace("-", "_") + ".png"; ;
            return Ok(fileName);
        }
    }
}
