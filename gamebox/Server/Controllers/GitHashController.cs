using Microsoft.AspNetCore.Mvc;

namespace gamebox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHashController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string githash = Environment.GetEnvironmentVariable("githash") ?? "dev";
            const int HASH_LENGTH = 8;
            return githash.Length > HASH_LENGTH ? githash.Substring(0, HASH_LENGTH) : githash;
        }
    }
}