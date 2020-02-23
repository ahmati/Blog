using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Data.Migrations
{
    public partial class Category_list_toPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_Category_Id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Category_Id",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Category_Name",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_PostId",
                table: "Categories",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Posts_PostId",
                table: "Categories",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Posts_PostId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_PostId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category_Name",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Category_Id",
                table: "Posts",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_Category_Id",
                table: "Posts",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
