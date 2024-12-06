using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thueOTo.Migrations
{
    /// <inheritdoc />
    public partial class themDuongDanAnhChoXe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sDuongDan",
                table: "tblPhuongTien",
                type: "nvarchar(max)",
                nullable: true
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblChucVu");

            migrationBuilder.DropTable(
                name: "tblHoaDon");

            migrationBuilder.DropTable(
                name: "tblPhieuBaoTri");

            migrationBuilder.DropTable(
                name: "tblPhieuNhapKho");

            migrationBuilder.DropTable(
                name: "tblPhieuXuatXe");

            migrationBuilder.DropTable(
                name: "tblTaiKhoan");

            migrationBuilder.DropTable(
                name: "tblKhachHang");

            migrationBuilder.DropTable(
                name: "tblPhuongTien");

            migrationBuilder.DropTable(
                name: "tblNhaCungCap");

            migrationBuilder.DropTable(
                name: "tblNhanVien");

            migrationBuilder.DropTable(
                name: "tblLoaiPhuongTien");
        }
    }
}
