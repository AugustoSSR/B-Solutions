using B_Solutions.Data;
using B_Solutions.Models;
using B_Solutions.Repositorio.Interface;

namespace B_Solutions.Repositorio
{
    public class EmpresasRepositorio : IEmpresasRepositorio
    {
        private readonly DataContext _bancoContext;
        public EmpresasRepositorio(DataContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public EmpresasModel ListarPorID(int id)
        {
            return _bancoContext.Empresas.FirstOrDefault(x => x.IdEmpresa == id);
        }
        public List<EmpresasModel> GetEmpresas()
        {
            // listagem de empresass
            return _bancoContext.Empresas.ToList();
        }
        public EmpresasModel Adicionar(EmpresasModel empresas)
        {
            // Inserção do banco de dados.
            empresas.empresaDataCadastro = DateTime.Now;
            _bancoContext.Empresas.Add(empresas);
            _bancoContext.SaveChanges();
            return empresas;
        }

        public EmpresasModel Atualizar(EmpresasModel empresas)
        {
            EmpresasModel empresasDB = ListarPorID(empresas.IdEmpresa);
            if (empresasDB == null) throw new System.Exception("Houve um erro na atualização do empresas.");
            empresasDB.empresaRazao = empresas.empresaRazao;
            empresasDB.empresaRuaCidade = empresas.empresaRuaCidade;
            empresasDB.empresaCNPJ = empresas.empresaCNPJ;
            empresasDB.empresaFantasia = empresas.empresaFantasia;
            empresasDB.empresaTelefone = empresas.empresaTelefone;
            empresasDB.empresaRua = empresas.empresaRua;
            empresasDB.empresaRuaNumero = empresas.empresaRuaNumero;
            empresasDB.empresaRuaBairro = empresas.empresaRuaBairro;
            empresasDB.empresaRuaCep = empresas.empresaRuaCep;
            empresasDB.empresaRuaEstado = empresas.empresaRuaEstado;
            // dados de comercial e responsavel da empresa
            empresasDB.empresaComercialCargo = empresas.empresaComercialCargo;
            empresasDB.empresaComercialCPF = empresas.empresaComercialCPF;
            empresasDB.empresaComercialEmail = empresas.empresaComercialEmail;
            empresasDB.empresaComercialNome = empresas.empresaComercialNome;
            empresasDB.empresaComercialRG = empresas.empresaComercialRG;

            empresasDB.empresaResponsavelCargo = empresas.empresaResponsavelCargo;
            empresasDB.empresaResponsavelCPF = empresas.empresaResponsavelCPF;
            empresasDB.empresaResponsavelEmail = empresas.empresaResponsavelEmail;
            empresasDB.empresaResponsavelNome = empresas.empresaResponsavelNome;
            empresasDB.empresaResponsavelRG = empresas.empresaResponsavelRG;

            // data de alteração da empresa.
            empresasDB.empresaDataAlteracao = DateTime.Now;

            _bancoContext.Empresas.Update(empresasDB);
            _bancoContext.SaveChanges();

            return empresasDB;
        }

        public bool Apagar(int id)
        {
            EmpresasModel empresasDB = ListarPorID(id);

            if (empresasDB == null) throw new System.Exception("Houve um erro na deleção do empresas.");

            _bancoContext.Empresas.Remove(empresasDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
