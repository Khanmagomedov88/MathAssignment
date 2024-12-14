using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maths.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMathExampleSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExampleImage",
                table: "MathExamples");

            migrationBuilder.RenameColumn(
                name: "ExampleName",
                table: "MathExamples",
                newName: "ExampleText");

            migrationBuilder.AddColumn<int>(
                name: "DifficultyLevel",
                table: "MathExamples",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DifficultyLevel",
                table: "MathExamples");

            migrationBuilder.RenameColumn(
                name: "ExampleText",
                table: "MathExamples",
                newName: "ExampleName");

            migrationBuilder.AddColumn<byte[]>(
                name: "ExampleImage",
                table: "MathExamples",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
