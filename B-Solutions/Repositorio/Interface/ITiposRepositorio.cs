using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface ITiposRepositorio
    {
        List<TipoProjetoModel> GetTipos();
        TipoProjetoModel ListarPorID(int id);
        TipoProjetoModel Adicionar(TipoProjetoModel tipos);
        TipoProjetoModel Atualizar(TipoProjetoModel tipos);

        bool Apagar(int id);

    }
}
