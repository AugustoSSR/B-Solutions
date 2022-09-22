using B_Solutions.Data;
using B_Solutions.Filters;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ProjetosController : Controller
    {
        private readonly IProjetosRepositorio _projetosRepositorio;
        public ProjetosController(IProjetosRepositorio projetosRepositorio)
        {
            _projetosRepositorio = projetosRepositorio;
        }
        public IActionResult Index()
        {
            List<ProjetoModel> projetos = _projetosRepositorio.GetProjetos();
            return View(projetos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ProjetoModel projeto = _projetosRepositorio.ListarPorID(id);
            return View(projeto);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ProjetoModel projeto = _projetosRepositorio.ListarPorID(id);
            return View(projeto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _projetosRepositorio.Apagar(id);

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
        public IActionResult Adicionar(ProjetoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _projetosRepositorio.Adicionar(projeto);
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
        public IActionResult Editar(ProjetoModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _projetosRepositorio.Atualizar(projeto);
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
