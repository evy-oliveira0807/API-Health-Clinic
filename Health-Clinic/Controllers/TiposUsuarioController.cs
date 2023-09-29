using Health_Clinic.Domains;
using Health_Clinic.Interfaces;
using Health_Clinic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Health_Clinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository;

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }
        [HttpPost]

        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);
                return StatusCode(201);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposUsuarioRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

         
        }
    }
}
