using Microsoft.EntityFrameworkCore.Migrations;

namespace Migra.Migrations
{
    public partial class InitWebdb_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articleTags",
                columns: table => new
                {
                    ArticleTagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    TagID = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articleTags", x => x.ArticleTagID);
                    table.ForeignKey(
                        name: "FK_articleTags_article_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "article",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_articleTags_tags_TagID",
                        column: x => x.TagID,
                        principalTable: "tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_ArticleID_TagID",
                table: "articleTags",
                columns: new[] { "ArticleID", "TagID" },
                unique: true,
                filter: "[TagID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_articleTags_TagID",
                table: "articleTags",
                column: "TagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articleTags");
        }
    }
}
