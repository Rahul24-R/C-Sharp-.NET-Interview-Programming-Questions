using APIExtension.CodeFormatter;
using Microsoft.AspNetCore.Mvc;

namespace APIExtension.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ProgramController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            CodeRead codeRead = new CodeRead("C:\\Rahul\\Personal\\Learnings\\LearningQuestions\\C#ProgrammingQuestions\\ReverseString\\ReverseString.cs");
            return Ok(codeRead.EncodeCode());
        }
    }
}
