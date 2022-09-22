using B_Solutions.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B_Solutions.Repositorio.Interface
{
    public interface IEmpresasRepositorio
    {
        List<EmpresasModel> GetEmpresas();
        EmpresasModel ListarPorID(int id);
        EmpresasModel Adicionar(EmpresasModel empresas);
        EmpresasModel Atualizar(EmpresasModel empresas);

        bool Apagar(int id);

    }
}
