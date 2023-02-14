using System.ComponentModel.DataAnnotations;

namespace BlocodeNotasApi.Models.DTO
{
    public class UpdateNotesDTO
    {

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100)]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(500)]
        public string? Descricao { get; set; }

    }
}
