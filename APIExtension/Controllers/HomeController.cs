using Microsoft.AspNetCore.Mvc;
using ProgramBase;

namespace APIExtension.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class HomeController : Controller
    {
        private BaseClass baseClass { get; set; }
        public HomeController()
        {
            baseClass = new BaseClass();
        }
        [HttpGet]
        public ActionResult<Dictionary<int,string>> Get()
        {
            return Ok(baseClass.selectionOption);
        }
    }
}
