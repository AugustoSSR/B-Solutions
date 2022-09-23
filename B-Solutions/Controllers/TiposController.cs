using B_Solutions.Filters;
using B_Solutions.Helper;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class TiposController : Controller
    {
        private readonly ITiposRepositorio _tiposRepositorio;
        public TiposController(ITiposRepositorio tiposRepositorio)
        {
            _tiposRepositorio = tiposRepositorio;
        }
        public IActionResult Index()
        {
            List<TipoProjetoModel> tipos = _tiposRepositorio.GetTipos();
            return View(tipos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            TipoProjetoModel tipos = _tiposRepositorio.ListarPorID(id);
            return PartialView(tipos);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            TipoProjetoModel tipos = _tiposRepositorio.ListarPorID(id);
            return View(tipos);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _tiposRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = " Projeto apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Adicionar(TipoProjetoModel tipos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _tiposRepositorio.Adicionar(tipos);
                    TempData["MensagemSucesso"] = " Projeto cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(tipos);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(TipoProjetoModel tipos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _tiposRepositorio.Atualizar(tipos);
                    TempData["MensagemSucesso"] = " Projeto alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(tipos);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
