using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTest.Migrations
{
    public partial class AddArticleCommentTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Articles",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Articles", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "T_Comments",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AriticleCodeRef = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AuditTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Comments", x => x.Code);
                    table.ForeignKey(
                        name: "FK_T_Comments_T_Articles_AriticleCodeRef",
                        column: x => x.AriticleCodeRef,
                        principalTable: "T_Articles",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Comments_AriticleCodeRef",
                table: "T_Comments",
                column: "AriticleCodeRef");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Comments");

            migrationBuilder.DropTable(
                name: "T_Articles");
        }
    }
}
