using B_Solutions.Enums;
using B_Solutions.Helper;
using System.ComponentModel.DataAnnotations;

namespace B_Solutions.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuario.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "O nome de usuario deve conter entre 5 e 10 caracteres.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do usuario.")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O celular informado está errado")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite sua senha por favor.")]
        //[StringLength(16, MinimumLength = 8, ErrorMessage = "A senha do usuario deve conter entre 8 e 16 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o cargo do usuario")]
        public PerfilEnum? Perfil { get; set; }
        public int? idPerfil { get; set; }
        [Required]
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }
        public void SetNovaSenha(string novaSenha)
        {
            Senha = novaSenha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            // gerar nova senha com hash sha1.
            string novaSenha = Guid.NewGuid().ToString().Substring(0 , 8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }

    }
}
