using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase {

        [HttpGet]
        public string Get() {
            return "Running";
        }
    }
}
