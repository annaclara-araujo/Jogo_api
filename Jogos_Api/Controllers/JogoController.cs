using Jogos_Api.Domains;
using Jogos_Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jogos_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoController(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }


        [HttpPost]

        public IActionResult Post(Jogo novoJogo)
        {
            try
            {
                _jogoRepository.Cadastrar(novoJogo);

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
                return Ok(_jogoRepository.Listar());
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
                _jogoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }

        }


        [HttpPut("{id}")]

        public IActionResult Put(Guid id, Jogo jogo)
        {
            try
            {
                _jogoRepository.Atualizar(id, jogo);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
