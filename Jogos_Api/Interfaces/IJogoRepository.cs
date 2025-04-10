using Jogos_Api.Domains;

namespace Jogos_Api.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        void Deletar(Guid id);
        void Atualizar(Guid id, Jogo jogo);
        List<Jogo> Listar();
    }
}
