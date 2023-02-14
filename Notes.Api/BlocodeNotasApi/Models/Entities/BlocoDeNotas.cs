using System.ComponentModel.DataAnnotations;

namespace BlocodeNotasApi.Models.Entities
{
    public class BlocoDeNotas
    {
        public BlocoDeNotas(string? titulo, string? descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }
        [Key]
        [Required]
        public int Id { get; protected set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Titulo { get; private set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        [StringLength(500)]
        public string? Descricao { get; private set; }
    }
}
