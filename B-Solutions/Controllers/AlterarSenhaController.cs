using B_Solutions.Filters;
using B_Solutions.Helper;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class AlterarSenhaController : Controller
    {
        private readonly IUsuariosRepositorio _usuariosRepositorio;
        private readonly IEmail _email;
        private readonly ISessao _sessao;

        public AlterarSenhaController(IUsuariosRepositorio usuariosRepositorio, 
            IEmail email,
            ISessao sessao)
        {
            _usuariosRepositorio = usuariosRepositorio;
            _email = email;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Alterar(AlterarSenhaModel alterarSenhaModel)
        {
            try
            {
                UsuariosModel usuarioLogado = _sessao.BuscarSessaoUsuario();
                UsuariosModel usuarioEmail = _usuariosRepositorio.BuscarPorEmail(usuarioLogado.usuarioEmail, usuarioLogado.usuarioLogin);
                alterarSenhaModel.alterarId = usuarioLogado.usuarioId;
                if (ModelState.IsValid)
                { 
                    _usuariosRepositorio.AlterarSenha(alterarSenhaModel);

                    string mensagem = $"Ola, sua senha foi alterada com sucesso, caso não tenha sido você, faça agora mesmo a redefinição da sua senha.";

                    bool emailEnviado = _email.Enviar(usuarioEmail.usuarioEmail, "B Solutions - Alteração de Senha", mensagem);

                    if (emailEnviado)
                    {
                        _usuariosRepositorio.Atualizar(usuarioEmail);
                        TempData["MensagemSucesso"] = "Foi enviado um link para o seu e-mail cadastrado.";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Não conseguimos enviar o e-mail, por favor tente novamente.";
                    }


                    TempData["MensagemSucesso"] = "Senha alterada com sucesso.";
                    return View("Index", alterarSenhaModel);
                }

                return View("Index", alterarSenhaModel);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops! - Não conseguimos alterar sua senha, tente novamente. Erro: {erro.Message}";
                return View("Index", alterarSenhaModel);
            }
        }
    }
}
