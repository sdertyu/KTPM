using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thueOTo.Migrations
{
    /// <inheritdoc />
    public partial class themTrangThai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "sTrangThai",
                table: "tblPhuongTien",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sTrangThai",
                table: "tblPhuongTien");
        }
    }
}
