using B_Solutions.Data;
using B_Solutions.Filters;
using B_Solutions.Models;
using B_Solutions.Repositorio;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class EmpresasController : Controller
    {
        private readonly IEmpresasRepositorio _empresasRepositorio;
        public EmpresasController(IEmpresasRepositorio empresasRepositorio)
        {
            _empresasRepositorio = empresasRepositorio;

        }
        public IActionResult Index()
        {
            List<EmpresasModel> projetos = _empresasRepositorio.GetEmpresas();
            return View(projetos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EmpresasModel projeto = _empresasRepositorio.ListarPorID(id);
            return View(projeto);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            EmpresasModel projeto = _empresasRepositorio.ListarPorID(id);
            return View(projeto);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _empresasRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "A empresa foi apagada com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "A empresa não pode ser excluida por que possui um erro";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel apagar a empresa, tente novamente. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Copiar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(EmpresasModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empresasRepositorio.Adicionar(projeto);
                    TempData["MensagemSucesso"] = "A empresa foi adicionada com sucesso";
                    return RedirectToAction("Index");
                }
                return View(projeto);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"A empresa não pode ser adicionada, tente novamente. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(EmpresasModel projeto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empresasRepositorio.Atualizar(projeto);
                    TempData["MensagemSucesso"] = "A empresa foi editada com sucesso";
                    return RedirectToAction("Index");

                }
                return View(projeto);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel editar a empresa, tente novamente. Erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
