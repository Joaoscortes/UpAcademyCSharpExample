using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApi.Controllers {
    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase {
        [HttpGet]
        public int Sum (int a, int b) {
            return a + b;
        }

        [HttpGet]
        public int Product (int a, int b) {
            return a * b;
        }
    }
}