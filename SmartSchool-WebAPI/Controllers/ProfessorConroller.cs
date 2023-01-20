using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
            [ApiController]
            [Route("api/[controller]")]
    public class ProfessorConroller : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Osvaldo Abel");
        }
    }
}



