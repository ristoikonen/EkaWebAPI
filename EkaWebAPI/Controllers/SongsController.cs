using Microsoft.AspNetCore.Mvc;
using EkaWebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EkaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // GET: api/<SongsController>

        [HttpGet]
        public async Task<IEnumerable<string>> Names()
        {

            Cosmo cos = new Cosmo();
            await cos.GetStartedDemoAsync();

            return new string[] { "value1", "value2" };
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public FileContentResult Get(long id)
        {
            //  byte[]
            // UgotItALL

            string path = @"C:\temp\ugotItAll.wav";
            FileInfo info = new FileInfo(path);
            byte[] bytess = new byte[info.Length];

            bytess = System.IO.File.ReadAllBytes(path);
            // File f = new File(bytess, "audio/mpeg,ugotItAll.wav");
            /*
             return new FileContentResult(attachment.File, 
        MimeTypeMap.GetMimeType(attachment.FileExtension))
    {
        FileDownloadName = $"{attachment.NomeFile}.{attachment.FileExtension}"
    };
             */

            return File(bytess, "audio/mpeg", "ugotItAll.wav");

            //return new MemoryStream(10).GetBuffer();

        }

        // GET api/<SongsController>/5
        [HttpGet("{id}/{fileid}")]
        public ActionResult GetFile(long id, string fileid)
        {
            // UgotItALL

            string path = @"C:\temp\UgotItALL.wav";
            FileInfo info = new FileInfo(path);
            byte[] bytess = new byte[info.Length];

            //System.IO.File.WriteAllBytes(path, bytess);
            bytess = System.IO.File.ReadAllBytes(path);

            return File(bytess, "audio/wav,UgotItALL.wav");

        }

        // POST api/<SongsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
