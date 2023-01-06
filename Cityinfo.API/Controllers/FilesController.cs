using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpGet("{fileid}")]
        public ActionResult GetFile (string fileId)
        {
            // look up the actual file, depending on the filed...
            // demo code
            var pathToFile = "";

            // ckeck whether the file exists
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            
            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, "text/plain", Path.GetFileName(pathToFile));
        }
    }
}
