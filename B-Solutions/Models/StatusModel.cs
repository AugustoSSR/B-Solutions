using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class StatusModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Coloque o nome do status")]
        public string Nome { get; set; }
        public bool? IsActive { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
    }
}
