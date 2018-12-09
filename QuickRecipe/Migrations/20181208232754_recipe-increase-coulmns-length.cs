using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickRecipe.Migrations
{
    public partial class recipeincreasecoulmnslength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "recipes",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cooking_time",
                table: "recipes",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "recipes",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "recipes",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cooking_time",
                table: "recipes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "recipes",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
