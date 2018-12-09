using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickRecipe.Migrations
{
    public partial class insertedrecipepreviewcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "preview",
                table: "recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "preview",
                table: "recipes");
        }
    }
}
