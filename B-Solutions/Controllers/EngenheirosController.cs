using B_Solutions.Filters;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class EngenheirosController : Controller
    {
        private readonly IEngenheirosRepositorio _engenheirosRepositorio;
        public EngenheirosController(IEngenheirosRepositorio engenheirosRepositorio)
        {
            _engenheirosRepositorio = engenheirosRepositorio;
        }
        public IActionResult Index()
        {
            List<EngenheirosModel> projetos = _engenheirosRepositorio.GetEngenheiros();

            return View(projetos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EngenheirosModel projeto = _engenheirosRepositorio.ListarPorID(id);
            return View(projeto);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            EngenheirosModel projeto = _engenheirosRepositorio.ListarPorID(id);
            return View(projeto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _engenheirosRepositorio.Apagar(id);

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

        public IActionResult Copiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(EngenheirosModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _engenheirosRepositorio.Adicionar(projeto);
                    TempData["MensagemSucesso"] = " Projeto cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(projeto);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(EngenheirosModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _engenheirosRepositorio.Atualizar(projeto);
                    TempData["MensagemSucesso"] = " Projeto alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(projeto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
