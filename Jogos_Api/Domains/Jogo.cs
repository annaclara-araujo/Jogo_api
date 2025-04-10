using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jogos_Api.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid JogoId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do Jogo é obrigatório")]
        public string? NomeJogo { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A plataforma do jogo é obrigatória")]
        public string? Plataforma { get; set; }

    }
}
