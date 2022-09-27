﻿// <auto-generated />
using System;
using B_Solutions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B_Solutions.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("B_Solutions.Models.ArquivosModel", b =>
                {
                    b.Property<int>("IdArquivo")
                        .HasColumnType("int");

                    b.Property<string>("arquivoCaderno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arquivoCaixa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("arquivoDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("arquivoDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("arquivoEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arquivoLocalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arquivoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idArquivoEmpresa")
                        .HasColumnType("int");

                    b.ToTable("Arquivos");
                });

            modelBuilder.Entity("B_Solutions.Models.CargoModel", b =>
                {
                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("cargoDataAlteraaco")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cargoDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("cargoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("B_Solutions.Models.EmpresasModel", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("empresaCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaComercialCPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaComercialCargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaComercialEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaComercialNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaComercialRG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("empresaDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("empresaDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("empresaFantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRazao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaResponsavelCPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaResponsavelCargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaResponsavelEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaResponsavelNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaResponsavelRG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRuaBairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRuaCep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRuaCidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRuaEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaRuaNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empresaTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("B_Solutions.Models.EngenheirosModel", b =>
                {
                    b.Property<int>("IdEngenheiro")
                        .HasColumnType("int");

                    b.Property<string>("engenheiroCPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("engenheiroCREA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("engenheiroDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("engenheiroDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("engenheiroEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("engenheiroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Engenheiros");
                });

            modelBuilder.Entity("B_Solutions.Models.ProjetoModel", b =>
                {
                    b.Property<int>("IdProjeto")
                        .HasColumnType("int");

                    b.Property<int>("idProjetoConcessionaria")
                        .HasColumnType("int");

                    b.Property<int>("idProjetoEmpresa")
                        .HasColumnType("int");

                    b.Property<int>("idProjetoStatus")
                        .HasColumnType("int");

                    b.Property<int>("idProjetoTipo")
                        .HasColumnType("int");

                    b.Property<string>("projetoART")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoConcessionaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("projetoDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("projetoDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("projetoEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoEngenheiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoLocalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoObservacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoProtocolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projetoTipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("B_Solutions.Models.StatusModel", b =>
                {
                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("statusDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("statusDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("statusNome")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("B_Solutions.Models.TipoProjetoModel", b =>
                {
                    b.Property<int>("IdProjetoTipo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("tipoProjetoDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("tipoProjetoDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("tipoProjetoNome")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("B_Solutions.Models.UsuariosModel", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("usuarioCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("usuarioDataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("usuarioDataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("usuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("usuarioIdCargo")
                        .HasColumnType("int");

                    b.Property<string>("usuarioLogin")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("usuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuarioSenha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("usuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
