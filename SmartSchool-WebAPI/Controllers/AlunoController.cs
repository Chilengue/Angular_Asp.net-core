using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
            [ApiController]
            [Route("api/[controller]")]
    public class AlunoController  : ControllerBase
    {
        public IActionResult Get()
        {
            try
            {
                return Ok("");
                //throw new Exception("apenas  um teste");
            }
            catch (System.Exception ex)
            {
                
                return Ok($"Erro: {ex.Message}");
            }
           
        }
    }
}