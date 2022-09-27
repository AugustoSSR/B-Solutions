using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B_Solutions.Migrations
{
    public partial class dbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arquivos",
                columns: table => new
                {
                    IdArquivo = table.Column<int>(type: "int", nullable: false),
                    arquivoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arquivoCaderno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arquivoCaixa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arquivoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idArquivoEmpresa = table.Column<int>(type: "int", nullable: false),
                    arquivoLocalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arquivoDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    arquivoDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    cargoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargoDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cargoDataAlteraaco = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    empresaFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRazao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRuaNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRuaBairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRuaCidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRuaEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaRuaCep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empresaComercialEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaComercialCPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaComercialRG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaComercialNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaComercialCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaResponsavelEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaResponsavelCPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaResponsavelRG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaResponsavelNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaResponsavelCargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empresaDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    empresaDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Engenheiros",
                columns: table => new
                {
                    IdEngenheiro = table.Column<int>(type: "int", nullable: false),
                    engenheiroNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    engenheiroCPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    engenheiroCREA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    engenheiroEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    engenheiroDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    engenheiroDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Projetos",
                columns: table => new
                {
                    IdProjeto = table.Column<int>(type: "int", nullable: false),
                    projetoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projetoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idProjetoEmpresa = table.Column<int>(type: "int", nullable: false),
                    projetoTipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idProjetoTipo = table.Column<int>(type: "int", nullable: false),
                    projetoConcessionaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idProjetoConcessionaria = table.Column<int>(type: "int", nullable: false),
                    projetoLocalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projetoEngenheiro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projetoStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idProjetoStatus = table.Column<int>(type: "int", nullable: false),
                    projetoART = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projetoProtocolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projetoObservacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projetoDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projetoDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    statusNome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    statusDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    statusDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    IdProjetoTipo = table.Column<int>(type: "int", nullable: false),
                    tipoProjetoNome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    tipoProjetoDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoProjetoDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    usuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioLogin = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    usuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioSenha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    usuarioCargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioIdCargo = table.Column<int>(type: "int", nullable: true),
                    usuarioDataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioDataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivos");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "Engenheiros");

            migrationBuilder.DropTable(
                name: "Projetos");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
