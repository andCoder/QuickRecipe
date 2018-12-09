using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickRecipe.Migrations
{
    public partial class increasedrecipecookingtimelength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cooking_time",
                table: "recipes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "cooking_time",
                table: "recipes",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
