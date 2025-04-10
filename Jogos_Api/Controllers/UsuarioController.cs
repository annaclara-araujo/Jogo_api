using Jogos_Api.Domains;
using Jogos_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jogos_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpPost]

        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);

                return Created();
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
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(Guid id)
        {

            try
            {
                _usuarioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }

        }


        [HttpPut("{id}")]

        public IActionResult Put(Guid id, Usuario usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(id, usuario);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
