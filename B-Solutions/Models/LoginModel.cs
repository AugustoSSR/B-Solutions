using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login do usuario.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite sua senha.")]
        //[StringLength(16, MinimumLength = 8, ErrorMessage = "A senha do usuario deve conter entre 8 e 16 caracteres.")]
        public string Senha { get; set; } 
    }
}
