using Jogos_Api.Contexts;
using Jogos_Api.Domains;
using Jogos_Api.Interfaces;

namespace Jogos_Api.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly Context _context;

        public JogoRepository(Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Jogo novoJogo)

        {
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    jogoBuscado.NomeJogo = novoJogo.NomeJogo;
                }
                _context.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Jogo novoJogo)
        {

            _context.Jogo.Add(novoJogo);
            _context.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            try
            {
               Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    _context.Jogo.Remove(jogoBuscado);
                }

                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                List<Jogo> listaJogo = _context.Jogo.ToList();
                return listaJogo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
