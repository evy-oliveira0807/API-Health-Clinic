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
    public class ProntuarioController : ControllerBase
    {
        private ProntuarioRepository _prontuarioRepository { get; set; }
        public ProntuarioController()
        {
            _prontuarioRepository = new ProntuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Prontuario prontuario)
        {
            try
            {
                _prontuarioRepository = new ProntuarioRepository();
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id)
        {

            try 
            {
                _prontuarioRepository.Delete(id);
                    return Ok();

            
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
                return Ok(_prontuarioRepository.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        
    }
}

