using Jogos_Api.Domains;

namespace Jogos_Api.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        void Deletar(Guid id);
        void Atualizar(Guid id, Usuario novoUsuario);
        List<Usuario> Listar();

    }
}