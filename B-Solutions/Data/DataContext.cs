using B_Solutions.Models;
using Microsoft.EntityFrameworkCore;

namespace B_Solutions.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<ProjetoModel> Projetos { get; set; }
        public DbSet<ArquivosModel> Arquivos { get; set; }
        public DbSet<EngenheirosModel> Engenheiros { get; set; }
        public DbSet<EmpresasModel> Empresas { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<PerfilModel> Perfil { get; set; }
        public DbSet<TiposModel> Tipos { get; set; }
        public DbSet<StatusModel> Status { get; set; }
    }
}
