using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExtraORM.Migrations
{
    /// <inheritdoc />
    public partial class RemoverTurmasEDepartamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Turmas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorChefeId = table.Column<int>(type: "int", nullable: false),
                    DepartamentoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                    table.ForeignKey(
                        name: "FK_Departamentos_Professor_ProfessorChefeId",
                        column: x => x.ProfessorChefeId,
                        principalTable: "Professor",
                        principalColumn: "ProfessorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    TurmaId = table.Column<int>(name: "Turma Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurmaAnoLetivo = table.Column<int>(name: "Turma Ano Letivo", type: "int", nullable: false),
                    NomeTurma = table.Column<string>(name: "Nome Turma", type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.TurmaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_ProfessorChefeId",
                table: "Departamentos",
                column: "ProfessorChefeId");
        }
    }
}
