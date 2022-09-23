using System.ComponentModel.DataAnnotations;
namespace B_Solutions.Models
{
    public class TipoProjetoModel
    {
        public int tipoProjetoId { get; set; }
        [Required(ErrorMessage = "Coloque o nome do tipo")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "O nome deve conter de 2 a 25 caracteres.")]
        public string tipoProjetoNome { get; set; }
        public DateTime tipoProjetoDataCadastro { get; set; }
        public DateTime? tipoProjetoDataAlteracao { get; set; }
    }
}
