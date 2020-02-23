using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Data.Migrations
{
    public partial class Remove_CategoryFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }
    }
}
