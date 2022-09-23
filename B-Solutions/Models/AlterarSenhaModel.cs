using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class AlterarSenhaModel
    {
        public int alterarId { get; set; }
        [Required(ErrorMessage = "Digite sua senha por favor.")]
        public string alterarSenhaAtual { get; set; }
        [Required(ErrorMessage = "Digite a nova senha.")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "A senha do usuario deve conter entre 8 e 16 caracteres.")]
        public string alterarSenhaNova { get; set; }
        [Required(ErrorMessage = "Confirme a nova senha.")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "A senha do usuario deve conter entre 8 e 16 caracteres.")]
        [Compare("NovaSenha", ErrorMessage = "As senhas não conferem.")]
        public string alterarConfirmarSenha { get; set; }

    }
}
