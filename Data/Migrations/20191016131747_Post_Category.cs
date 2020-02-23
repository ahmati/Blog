using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Data.Migrations
{
    public partial class Post_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Category_Name = table.Column<string>(nullable: true),
                    Category_Id = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Short_description = table.Column<string>(nullable: true),
                    Long_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post_Categories",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    Category_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Categories", x => new { x.PostId, x.Category_Id });
                    table.ForeignKey(
                        name: "FK_Post_Categories_Categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Categories_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_Categories_Category_Id",
                table: "Post_Categories",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Category_Id",
                table: "Posts",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post_Categories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
