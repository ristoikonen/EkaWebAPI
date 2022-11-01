using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EkaWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public byte[] Get(long id)
        {
            // UgotItALL
            
            string path = @"C:\temp\UgotItALL.wav";
            System.IO.FileInfo info = new FileInfo(path);
            byte[] bytess = new byte[info.Length];

            bytess= System.IO.File.ReadAllBytes(path);
            // File f = new File(bytess, "audio/mpeg,UgotItALL.wav");

            return new MemoryStream(10).GetBuffer();
            
        }  

        // GET api/<SongsController>/5
        [HttpGet("{id}/{fileid}")]
        public ActionResult GetFile(long id,string fileid)
        {
            // UgotItALL

            string path = @"C:\temp\UgotItALL.wav";
            System.IO.FileInfo info = new FileInfo(path);
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
