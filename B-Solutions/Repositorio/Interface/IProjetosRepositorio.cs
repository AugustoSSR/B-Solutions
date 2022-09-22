using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface IProjetosRepositorio
    {
        List<ProjetoModel> GetProjetos();
        ProjetoModel ListarPorID(int id);
        ProjetoModel Adicionar(ProjetoModel projeto);
        ProjetoModel Atualizar(ProjetoModel projeto);

        bool Apagar(int id);

    }
}
