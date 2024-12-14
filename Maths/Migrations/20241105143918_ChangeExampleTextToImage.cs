using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Maths.Migrations
{
    /// <inheritdoc />
    public partial class ChangeExampleTextToImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExampleText",
                table: "MathExamples");

            migrationBuilder.AddColumn<byte[]>(
                name: "ExampleImage",
                table: "MathExamples",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExampleImage",
                table: "MathExamples");

            migrationBuilder.AddColumn<string>(
                name: "ExampleText",
                table: "MathExamples",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
