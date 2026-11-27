using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExtraORM.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaDepartamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProfessorChefeId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_ProfessorChefeId",
                table: "Departamentos",
                column: "ProfessorChefeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
