using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExtraORM.Migrations
{
    /// <inheritdoc />
    public partial class TabelaTurmas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    TurmaId = table.Column<int>(name: "Turma Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTurma = table.Column<string>(name: "Nome Turma", type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TurmaAnoLetivo = table.Column<int>(name: "Turma Ano Letivo", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.TurmaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
