using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickRecipe.Migrations
{
    public partial class modifiedproductamountcolumnttype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "amount",
                table: "products",
                nullable: true,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "amount",
                table: "products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
