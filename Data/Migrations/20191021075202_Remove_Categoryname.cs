using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Data.Migrations
{
    public partial class Remove_Categoryname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "Posts",
                nullable: true);
        }
    }
}
