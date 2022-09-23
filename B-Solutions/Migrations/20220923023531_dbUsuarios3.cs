using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B_Solutions.Migrations
{
    public partial class dbUsuarios3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idPerfil",
                table: "Usuarios",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idPerfil",
                table: "Usuarios");
        }
    }
}
