using Microsoft.EntityFrameworkCore.Migrations;

namespace Enem.WebAPI.Migrations
{
    public partial class CandidatosConcurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Candidatos",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Candidatos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Candidatos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Concursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoConcurso",
                columns: table => new
                {
                    IdCandidato = table.Column<int>(nullable: false),
                    IdConcurso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoConcurso", x => new { x.IdCandidato, x.IdConcurso });
                    table.ForeignKey(
                        name: "FK_CandidatoConcurso_Candidatos_IdCandidato",
                        column: x => x.IdCandidato,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoConcurso_Concursos_IdConcurso",
                        column: x => x.IdConcurso,
                        principalTable: "Concursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoConcurso_IdConcurso",
                table: "CandidatoConcurso",
                column: "IdConcurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoConcurso");

            migrationBuilder.DropTable(
                name: "Concursos");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Candidatos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Candidatos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Candidatos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
