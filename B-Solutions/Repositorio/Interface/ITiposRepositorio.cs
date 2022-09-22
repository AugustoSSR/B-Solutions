using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface ITiposRepositorio
    {
        List<TiposModel> GetTipos();
        TiposModel ListarPorID(int id);
        TiposModel Adicionar(TiposModel tipos);
        TiposModel Atualizar(TiposModel tipos);

        bool Apagar(int id);

    }
}
