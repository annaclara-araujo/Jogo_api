using Jogos_Api.Contexts;
using Jogos_Api.Domains;
using Jogos_Api.Interfaces;

namespace Jogos_Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _context;

        public UsuarioRepository(Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Usuario usuario)
        {

            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    usuarioBuscado.NomeUsuario = usuarioBuscado.NomeUsuario;
                }

                _context.Usuario.Update(usuarioBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                return _context.Usuario.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuarios)
        {
            try
            {
                usuarios.UsuarioId = Guid.NewGuid();
                _context.Usuario.Add(usuarios);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Jogo jogo = _context.Jogo.Find(id)!;
                if (jogo != null)
                {
                    _context.Jogo.Remove(jogo);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }


}
