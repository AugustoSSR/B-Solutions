using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Por favor, digite o login.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Por favor digite o seu e-mail.")]
        [EmailAddress(ErrorMessage = "Por favor digite um e-mail válido.")]
        public string Email { get; set; }

    }
}
