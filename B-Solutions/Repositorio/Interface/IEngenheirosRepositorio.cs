using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface IEngenheirosRepositorio
    {
        List<EngenheirosModel> GetEngenheiros();
        EngenheirosModel ListarPorID(int id);
        EngenheirosModel Adicionar(EngenheirosModel engenheiros);
        EngenheirosModel Atualizar(EngenheirosModel engenheiros);

        bool Apagar(int id);

    }
}
