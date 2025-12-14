using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AiTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_added_banner_isActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Banners",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Banners");
        }
    }
}
