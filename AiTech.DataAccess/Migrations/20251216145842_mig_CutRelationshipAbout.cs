using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AiTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_CutRelationshipAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutItems");

            migrationBuilder.AddColumn<string>(
                name: "Skill1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill4",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Skill2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Skill3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Skill4",
                table: "Abouts");

            migrationBuilder.CreateTable(
                name: "AboutItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutItems_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_AboutId",
                table: "AboutItems",
                column: "AboutId");
        }
    }
}
