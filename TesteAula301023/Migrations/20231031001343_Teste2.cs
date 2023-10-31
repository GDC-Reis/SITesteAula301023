using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteAula301023.Migrations
{
    public partial class Teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Media",
                table: "Aluno",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Media",
                table: "Aluno");
        }
    }
}
