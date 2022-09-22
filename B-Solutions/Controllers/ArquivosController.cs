using B_Solutions.Filters;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace B_Solutions.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ArquivosController : Controller
    {
        private readonly IArquivoRepositorio _arquivoRepositorio;
        public ArquivosController(IArquivoRepositorio arquivoRepositorio)
        {
            _arquivoRepositorio = arquivoRepositorio;
        }
        public IActionResult Index()
        {
            List<ArquivosModel> arquivos = _arquivoRepositorio.GetArquivos();
            return View(arquivos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ArquivosModel arquivos = _arquivoRepositorio.ListarPorID(id);
            return View(arquivos);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ArquivosModel arquivos = _arquivoRepositorio.ListarPorID(id);
            return View(arquivos);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _arquivoRepositorio.Apagar(id);

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
        public IActionResult Adicionar(ArquivosModel arquivos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _arquivoRepositorio.Adicionar(arquivos);
                    TempData["MensagemSucesso"] = " Projeto cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(arquivos);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(ArquivosModel arquivos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _arquivoRepositorio.Atualizar(arquivos);
                    TempData["MensagemSucesso"] = " Projeto alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View(arquivos);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $" Seu projeto possui algum erro, tente novamente {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
