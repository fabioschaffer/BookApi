using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Book.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase {

        [HttpGet]
        public string Get() => Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}