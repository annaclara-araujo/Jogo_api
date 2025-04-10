

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jogos_Api.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public string? NomeUsuario { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nickname é obrigatório!")]
        public string? Nickname { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O jogo favorito é obrigatório!")]
        public string? JogoFavorito { get; set; }

        //referência para a entidade jogo
        [Required(ErrorMessage = "O jogo  é obrigatório!")]
        public Guid JogoId { get; set; }

        [ForeignKey("JogoId")]
        public Jogo? Jogo { get; set; }



    }
}

