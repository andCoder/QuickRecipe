using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickRecipe.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    recipeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 100, nullable: true),
                    description = table.Column<string>(maxLength: 300, nullable: true),
                    cooking_time = table.Column<string>(maxLength: 10, nullable: true),
                    portions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.recipeid);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    amount = table.Column<double>(nullable: false),
                    recipe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productid);
                    table.ForeignKey(
                        name: "FK_products_recipes_recipe",
                        column: x => x.recipe,
                        principalTable: "recipes",
                        principalColumn: "recipeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "steps",
                columns: table => new
                {
                    stepid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(maxLength: 256, nullable: true),
                    image = table.Column<string>(maxLength: 256, nullable: true),
                    recipe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_steps", x => x.stepid);
                    table.ForeignKey(
                        name: "FK_steps_recipes_recipe",
                        column: x => x.recipe,
                        principalTable: "recipes",
                        principalColumn: "recipeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_recipe",
                table: "products",
                column: "recipe");

            migrationBuilder.CreateIndex(
                name: "IX_steps_recipe",
                table: "steps",
                column: "recipe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "steps");

            migrationBuilder.DropTable(
                name: "recipes");
        }
    }
}
