using B_Solutions.Helper;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace B_Solutions.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        private readonly ISessao _sessao;
        private readonly IEmail _email;
        public LoginController(IUsuariosRepositorio usuariosRepositorio, 
            ISessao sessao, IEmail email)
        {   
            _usuariosRepositorio = usuariosRepositorio;
            _sessao = sessao;
            _email = email;
        }

        public IActionResult Index()
        {
            // se o usuario estive logado, redirecionar para a home
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult RedefinirSenha()
        {
            return View();
        }

        public IActionResult Sair()
        {
            TempData["MensagemSucesso"] = "Você deslogou ou foi descontado, digite novamente seu usuario e senha.";
            _sessao.removerSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    UsuariosModel usuario = _usuariosRepositorio.BuscarPorLogin(loginModel.Login);
                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.criarSessaoUsuario(usuario);
                            TempData["MensagemSucesso"] = $"Você logou com sucesso. Sejá bem vindo {usuario.Nome}";
                            return RedirectToAction("Index", "Home");
                        }
                        
                        TempData["MensagemErro"] = "A senha do usuário é inválida. Por favor, tente novamente.";
                    }
                    TempData["MensagemErro"] = "Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar o seu login. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult EnviarLink(RedefinirSenhaModel redefinirSenhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuariosModel usuario = _usuariosRepositorio.BuscarPorEmail(redefinirSenhaModel.Email, redefinirSenhaModel.Login);
                    if (usuario != null) 
                    {
                        string novaSenha = usuario.GerarNovaSenha();
                        string mensagem = $"Sua nova senha é: {novaSenha}";

                        bool emailEnviado = _email.Enviar(usuario.Email, "B Solutions - Redefinição de Senha", mensagem);

                        if (emailEnviado)
                        {
                            _usuariosRepositorio.Atualizar(usuario);
                            TempData["MensagemSucesso"] = "Foi enviado um link para o seu e-mail cadastrado.";
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Não conseguimos enviar o e-mail, por favor tente novamente.";
                        }

                        return RedirectToAction("Index", "Login");
                    }
                    TempData["MensagemErro"] = "Não conseguimos redefinir sua senha, pois não encontramos os dados informados.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos redefinir sua senha. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
