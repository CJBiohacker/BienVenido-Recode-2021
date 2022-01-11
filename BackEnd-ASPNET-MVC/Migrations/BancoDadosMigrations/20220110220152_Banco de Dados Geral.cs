using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.BancoDadosMigrations
{
    public partial class BancodeDadosGeral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculos",
                columns: table => new
                {
                    idCurriculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    DataNasc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empresa1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CargoTrab1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    PeriodoTrab1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescricaoTrab1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Empresa2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CargoTrab2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    PeriodoTrab2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescricaoTrab2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Instituicao1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Nivel1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Curso1 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Instituicao2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Nivel2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Curso2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Habilidades = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Idioma2 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Idioma3 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculos", x => x.idCurriculo);
                });

            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    IdFormulario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.IdFormulario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curriculos");

            migrationBuilder.DropTable(
                name: "Formularios");
        }
    }
}
