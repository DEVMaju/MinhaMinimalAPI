using Microsoft.AspNetCore.Mvc;

namespace MinhaMinimalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Exemplo1", "Exemplo2" };
        }

        [HttpPost]
        public IActionResult Post([FromBody] string valor)
        {
            return Ok(new { Mensagem = $"Valor recebido: {valor}" });
        }
    }