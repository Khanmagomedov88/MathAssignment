using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maths.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MathEquations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquationName = table.Column<string>(type: "TEXT", nullable: false),
                    EquationImage = table.Column<byte[]>(type: "BLOB", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathEquations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MathExamples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExampleName = table.Column<string>(type: "TEXT", nullable: false),
                    ExampleImage = table.Column<byte[]>(type: "BLOB", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathExamples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MathTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(type: "TEXT", nullable: false),
                    TaskImage = table.Column<byte[]>(type: "BLOB", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathTasks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MathEquations");

            migrationBuilder.DropTable(
                name: "MathExamples");

            migrationBuilder.DropTable(
                name: "MathTasks");
        }
    }
}
