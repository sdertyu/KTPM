﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using thueOTo.data;

#nullable disable

namespace thueOTo.Migrations
{
    [DbContext(typeof(QuanLyThueXeContext))]
    partial class QuanLyThueXeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("thueOTo.Models.TblChucVu", b =>
                {
                    b.Property<int>("IMaCv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaCV");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IMaCv"));

                    b.Property<double?>("FLuongCoBan")
                        .HasColumnType("float")
                        .HasColumnName("fLuongCoBan");

                    b.Property<string>("STenCv")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sTenCV");

                    b.HasKey("IMaCv")
                        .HasName("PK__tblChucV__F20AE40C630966F5");

                    b.ToTable("tblChucVu", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblHoaDon", b =>
                {
                    b.Property<int>("IMaHoaDon")
                        .HasColumnType("int")
                        .HasColumnName("iMaHoaDon");

                    b.Property<DateTime?>("DNgayThue")
                        .HasColumnType("datetime")
                        .HasColumnName("dNgayThue");

                    b.Property<DateTime?>("DNgayTra")
                        .HasColumnType("datetime")
                        .HasColumnName("dNgayTra");

                    b.Property<double?>("FTienCoc")
                        .HasColumnType("float")
                        .HasColumnName("fTienCoc");

                    b.Property<double?>("FTienThue")
                        .HasColumnType("float")
                        .HasColumnName("fTienThue");

                    b.Property<int?>("IMaKh")
                        .HasColumnType("int")
                        .HasColumnName("iMaKH");

                    b.Property<int?>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<int?>("IPhuongTien")
                        .HasColumnType("int")
                        .HasColumnName("iPhuongTien");

                    b.HasKey("IMaHoaDon")
                        .HasName("PK__tblHoaDo__0F47ABC494F45C73");

                    b.HasIndex("IMaKh");

                    b.HasIndex("IMaNv");

                    b.HasIndex("IPhuongTien");

                    b.ToTable("tblHoaDon", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblKhachHang", b =>
                {
                    b.Property<int>("IMaKh")
                        .HasColumnType("int")
                        .HasColumnName("iMaKH");

                    b.Property<string>("SCccd")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sCCCD");

                    b.Property<string>("SDiaChi")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sDiaChi");

                    b.Property<string>("SGioiTinh")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sGioiTinh");

                    b.Property<string>("SSdt")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("sSDT");

                    b.Property<string>("STenKh")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sTenKH");

                    b.HasKey("IMaKh")
                        .HasName("PK__tblKhach__F20AA508F1D84BF4");

                    b.ToTable("tblKhachHang", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblLoaiPhuongTien", b =>
                {
                    b.Property<int>("IMaLoaiPhuongTien")
                        .HasColumnType("int")
                        .HasColumnName("iMaLoaiPhuongTien");

                    b.Property<string>("SLoaiPhuongTien")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sLoaiPhuongTien");

                    b.HasKey("IMaLoaiPhuongTien")
                        .HasName("PK__tblLoaiP__303AFA6AE4CEB5F4");

                    b.ToTable("tblLoaiPhuongTien", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblNhaCungCap", b =>
                {
                    b.Property<string>("SMaNcc")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("sMaNCC");

                    b.Property<string>("STenNcc")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sTenNCC");

                    b.HasKey("SMaNcc")
                        .HasName("PK__tblNhaCu__FDC9EEF61C4ED364");

                    b.ToTable("tblNhaCungCap", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblNhanVien", b =>
                {
                    b.Property<int>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<int?>("IMaCv")
                        .HasColumnType("int")
                        .HasColumnName("iMaCV");

                    b.Property<string>("SCccd")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("sCCCD");

                    b.Property<string>("SDiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sDiaChi");

                    b.Property<string>("SGioiTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sGioiTinh");

                    b.Property<string>("SSdt")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("sSDT");

                    b.Property<string>("STenNv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("sTenNV");

                    b.HasKey("IMaNv")
                        .HasName("PK__tblNhanV__F20A8D79A40A2006");

                    b.ToTable("tblNhanVien", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuBaoTri", b =>
                {
                    b.Property<string>("SMaBt")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("sMaBT");

                    b.Property<DateTime?>("DThoiGian")
                        .HasColumnType("datetime")
                        .HasColumnName("dThoiGian");

                    b.Property<int?>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<int?>("IMaPhuongTien")
                        .HasColumnType("int")
                        .HasColumnName("iMaPhuongTien");

                    b.Property<string>("SGhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("sGhiChu");

                    b.HasKey("SMaBt")
                        .HasName("PK__tblPhieu__328E3D8222659195");

                    b.HasIndex("IMaNv");

                    b.HasIndex("IMaPhuongTien");

                    b.ToTable("tblPhieuBaoTri", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuNhapKho", b =>
                {
                    b.Property<int>("IMaPhieuNhap")
                        .HasColumnType("int")
                        .HasColumnName("iMaPhieuNhap");

                    b.Property<double?>("FTongGiaNhap")
                        .HasColumnType("float")
                        .HasColumnName("fTongGiaNhap");

                    b.Property<int?>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<int?>("IMaPhuongTien")
                        .HasColumnType("int")
                        .HasColumnName("iMaPhuongTien");

                    b.Property<string>("SMaNcc")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("sMaNCC");

                    b.HasKey("IMaPhieuNhap")
                        .HasName("PK__tblPhieu__23AF4DB19C5E385D");

                    b.HasIndex("IMaNv");

                    b.HasIndex("IMaPhuongTien");

                    b.HasIndex("SMaNcc");

                    b.ToTable("tblPhieuNhapKho", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuXuatXe", b =>
                {
                    b.Property<int>("IMaPhieuXuat")
                        .HasColumnType("int")
                        .HasColumnName("iMaPhieuXuat");

                    b.Property<double?>("FTongTien")
                        .HasColumnType("float")
                        .HasColumnName("fTongTien");

                    b.Property<int?>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<int?>("ITongSlx")
                        .HasColumnType("int")
                        .HasColumnName("iTongSLX");

                    b.HasKey("IMaPhieuXuat")
                        .HasName("PK__tblPhieu__EECC13AC92BAB950");

                    b.HasIndex("IMaNv");

                    b.ToTable("tblPhieuXuatXe", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblPhuongTien", b =>
                {
                    b.Property<int>("IMaPhuongTien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaPhuongTien");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IMaPhuongTien"));

                    b.Property<double?>("FGiaChoThue")
                        .HasColumnType("float")
                        .HasColumnName("fGiaChoThue");

                    b.Property<int?>("IMaLoaiPhuongTien")
                        .HasColumnType("int")
                        .HasColumnName("iMaLoaiPhuongTien");

                    b.Property<string>("SBienSoXe")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sBienSoXe");

                    b.Property<string>("STenPhuongTien")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sTenPhuongTien");

                    b.Property<string>("sDuongDan")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("sDuongDan");

                    b.Property<bool?>("sTrangThai")
                        .HasColumnType("bit")
                        .HasColumnName("sTrangThai");

                    b.HasKey("IMaPhuongTien")
                        .HasName("PK__tblPhuon__BAC9562E134F554D");

                    b.HasIndex("IMaLoaiPhuongTien");

                    b.ToTable("tblPhuongTien", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblTaiKhoan", b =>
                {
                    b.Property<int>("IMaTk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iMaTK");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IMaTk"));

                    b.Property<DateTime?>("DNgayCapTk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("dNgayCapTK")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("IMaNv")
                        .HasColumnType("int")
                        .HasColumnName("iMaNV");

                    b.Property<string>("SMatKhau")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("sMatKhau");

                    b.Property<string>("STaiKhoan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("sTaiKhoan");

                    b.HasKey("IMaTk")
                        .HasName("PK__tblTaiKh__F20A5E341E113505");

                    b.HasIndex("IMaNv");

                    b.ToTable("tblTaiKhoan", (string)null);
                });

            modelBuilder.Entity("thueOTo.Models.TblHoaDon", b =>
                {
                    b.HasOne("thueOTo.Models.TblKhachHang", "IMaKhNavigation")
                        .WithMany("TblHoaDons")
                        .HasForeignKey("IMaKh")
                        .HasConstraintName("FK__tblHoaDon__iMaKH__0F624AF8");

                    b.HasOne("thueOTo.Models.TblNhanVien", "IMaNvNavigation")
                        .WithMany("TblHoaDons")
                        .HasForeignKey("IMaNv")
                        .HasConstraintName("FK__tblHoaDon__iMaNV__0E6E26BF");

                    b.HasOne("thueOTo.Models.TblPhuongTien", "IPhuongTienNavigation")
                        .WithMany("TblHoaDons")
                        .HasForeignKey("IPhuongTien")
                        .HasConstraintName("FK__tblHoaDon__iPhuo__10566F31");

                    b.Navigation("IMaKhNavigation");

                    b.Navigation("IMaNvNavigation");

                    b.Navigation("IPhuongTienNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuBaoTri", b =>
                {
                    b.HasOne("thueOTo.Models.TblNhanVien", "IMaNvNavigation")
                        .WithMany("TblPhieuBaoTris")
                        .HasForeignKey("IMaNv")
                        .HasConstraintName("FK__tblPhieuB__iMaNV__14270015");

                    b.HasOne("thueOTo.Models.TblPhuongTien", "IMaPhuongTienNavigation")
                        .WithMany("TblPhieuBaoTris")
                        .HasForeignKey("IMaPhuongTien")
                        .HasConstraintName("FK__tblPhieuB__iMaPh__1332DBDC");

                    b.Navigation("IMaNvNavigation");

                    b.Navigation("IMaPhuongTienNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuNhapKho", b =>
                {
                    b.HasOne("thueOTo.Models.TblNhanVien", "IMaNvNavigation")
                        .WithMany("TblPhieuNhapKhos")
                        .HasForeignKey("IMaNv")
                        .HasConstraintName("FK__tblPhieuN__iMaNV__18EBB532");

                    b.HasOne("thueOTo.Models.TblPhuongTien", "IMaPhuongTienNavigation")
                        .WithMany("TblPhieuNhapKhos")
                        .HasForeignKey("IMaPhuongTien")
                        .HasConstraintName("FK__tblPhieuN__iMaPh__17036CC0");

                    b.HasOne("thueOTo.Models.TblNhaCungCap", "SMaNccNavigation")
                        .WithMany("TblPhieuNhapKhos")
                        .HasForeignKey("SMaNcc")
                        .HasConstraintName("FK__tblPhieuN__sMaNC__17F790F9");

                    b.Navigation("IMaNvNavigation");

                    b.Navigation("IMaPhuongTienNavigation");

                    b.Navigation("SMaNccNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblPhieuXuatXe", b =>
                {
                    b.HasOne("thueOTo.Models.TblNhanVien", "IMaNvNavigation")
                        .WithMany("TblPhieuXuatXes")
                        .HasForeignKey("IMaNv")
                        .HasConstraintName("FK__tblPhieuX__iMaNV__1BC821DD");

                    b.Navigation("IMaNvNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblPhuongTien", b =>
                {
                    b.HasOne("thueOTo.Models.TblLoaiPhuongTien", "IMaLoaiPhuongTienNavigation")
                        .WithMany("TblPhuongTiens")
                        .HasForeignKey("IMaLoaiPhuongTien")
                        .HasConstraintName("FK__tblPhuong__iMaLo__0B91BA14");

                    b.Navigation("IMaLoaiPhuongTienNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblTaiKhoan", b =>
                {
                    b.HasOne("thueOTo.Models.TblNhanVien", "IMaNvNavigation")
                        .WithMany("TblTaiKhoans")
                        .HasForeignKey("IMaNv")
                        .HasConstraintName("FK__tblTaiKho__iMaNV__03F0984C");

                    b.Navigation("IMaNvNavigation");
                });

            modelBuilder.Entity("thueOTo.Models.TblKhachHang", b =>
                {
                    b.Navigation("TblHoaDons");
                });

            modelBuilder.Entity("thueOTo.Models.TblLoaiPhuongTien", b =>
                {
                    b.Navigation("TblPhuongTiens");
                });

            modelBuilder.Entity("thueOTo.Models.TblNhaCungCap", b =>
                {
                    b.Navigation("TblPhieuNhapKhos");
                });

            modelBuilder.Entity("thueOTo.Models.TblNhanVien", b =>
                {
                    b.Navigation("TblHoaDons");

                    b.Navigation("TblPhieuBaoTris");

                    b.Navigation("TblPhieuNhapKhos");

                    b.Navigation("TblPhieuXuatXes");

                    b.Navigation("TblTaiKhoans");
                });

            modelBuilder.Entity("thueOTo.Models.TblPhuongTien", b =>
                {
                    b.Navigation("TblHoaDons");

                    b.Navigation("TblPhieuBaoTris");

                    b.Navigation("TblPhieuNhapKhos");
                });
#pragma warning restore 612, 618
        }
    }
}
