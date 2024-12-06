using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using thueOTo.Models;

namespace thueOTo.data;

public partial class QuanLyThueXeContext : DbContext
{
    public QuanLyThueXeContext()
    {
    }

    public QuanLyThueXeContext(DbContextOptions<QuanLyThueXeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblChucVu> TblChucVus { get; set; }

    public virtual DbSet<TblHoaDon> TblHoaDons { get; set; }

    public virtual DbSet<TblKhachHang> TblKhachHangs { get; set; }

    public virtual DbSet<TblLoaiPhuongTien> TblLoaiPhuongTiens { get; set; }

    public virtual DbSet<TblNhaCungCap> TblNhaCungCaps { get; set; }

    public virtual DbSet<TblNhanVien> TblNhanViens { get; set; }

    public virtual DbSet<TblPhieuBaoTri> TblPhieuBaoTris { get; set; }

    public virtual DbSet<TblPhieuNhapKho> TblPhieuNhapKhos { get; set; }

    public virtual DbSet<TblPhieuXuatXe> TblPhieuXuatXes { get; set; }

    public virtual DbSet<TblPhuongTien> TblPhuongTiens { get; set; }

    public virtual DbSet<TblTaiKhoan> TblTaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblChucVu>(entity =>
        {
            entity.HasKey(e => e.IMaCv).HasName("PK__tblChucV__F20AE40C630966F5");

            entity.ToTable("tblChucVu");

            entity.Property(e => e.IMaCv).HasColumnName("iMaCV");
            entity.Property(e => e.FLuongCoBan).HasColumnName("fLuongCoBan");
            entity.Property(e => e.STenCv)
                .HasMaxLength(200)
                .HasColumnName("sTenCV");
        });

        modelBuilder.Entity<TblHoaDon>(entity =>
        {
            entity.HasKey(e => e.IMaHoaDon).HasName("PK__tblHoaDo__0F47ABC494F45C73");

            entity.ToTable("tblHoaDon");

            entity.Property(e => e.IMaHoaDon)
                .ValueGeneratedNever()
                .HasColumnName("iMaHoaDon");
            entity.Property(e => e.DNgayThue)
                .HasColumnType("datetime")
                .HasColumnName("dNgayThue");
            entity.Property(e => e.DNgayTra)
                .HasColumnType("datetime")
                .HasColumnName("dNgayTra");
            entity.Property(e => e.FTienCoc).HasColumnName("fTienCoc");
            entity.Property(e => e.FTienThue).HasColumnName("fTienThue");
            entity.Property(e => e.IMaKh).HasColumnName("iMaKH");
            entity.Property(e => e.IMaNv).HasColumnName("iMaNV");
            entity.Property(e => e.IPhuongTien).HasColumnName("iPhuongTien");

            entity.HasOne(d => d.IMaKhNavigation).WithMany(p => p.TblHoaDons)
                .HasForeignKey(d => d.IMaKh)
                .HasConstraintName("FK__tblHoaDon__iMaKH__0F624AF8");

            entity.HasOne(d => d.IMaNvNavigation).WithMany(p => p.TblHoaDons)
                .HasForeignKey(d => d.IMaNv)
                .HasConstraintName("FK__tblHoaDon__iMaNV__0E6E26BF");

            entity.HasOne(d => d.IPhuongTienNavigation).WithMany(p => p.TblHoaDons)
                .HasForeignKey(d => d.IPhuongTien)
                .HasConstraintName("FK__tblHoaDon__iPhuo__10566F31");
        });

        modelBuilder.Entity<TblKhachHang>(entity =>
        {
            entity.HasKey(e => e.IMaKh).HasName("PK__tblKhach__F20AA508F1D84BF4");

            entity.ToTable("tblKhachHang");

            entity.Property(e => e.IMaKh)
                .ValueGeneratedNever()
                .HasColumnName("iMaKH");
            entity.Property(e => e.SCccd)
                .HasMaxLength(30)
                .HasColumnName("sCCCD");
            entity.Property(e => e.SDiaChi)
                .HasMaxLength(30)
                .HasColumnName("sDiaChi");
            entity.Property(e => e.SGioiTinh)
                .HasMaxLength(30)
                .HasColumnName("sGioiTinh");
            entity.Property(e => e.SSdt)
                .HasMaxLength(20)
                .HasColumnName("sSDT");
            entity.Property(e => e.STenKh)
                .HasMaxLength(30)
                .HasColumnName("sTenKH");
        });

        modelBuilder.Entity<TblLoaiPhuongTien>(entity =>
        {
            entity.HasKey(e => e.IMaLoaiPhuongTien).HasName("PK__tblLoaiP__303AFA6AE4CEB5F4");

            entity.ToTable("tblLoaiPhuongTien");

            entity.Property(e => e.IMaLoaiPhuongTien)
                .ValueGeneratedNever()
                .HasColumnName("iMaLoaiPhuongTien");
            entity.Property(e => e.SLoaiPhuongTien)
                .HasMaxLength(200)
                .HasColumnName("sLoaiPhuongTien");
        });

        modelBuilder.Entity<TblNhaCungCap>(entity =>
        {
            entity.HasKey(e => e.SMaNcc).HasName("PK__tblNhaCu__FDC9EEF61C4ED364");

            entity.ToTable("tblNhaCungCap");

            entity.Property(e => e.SMaNcc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sMaNCC");
            entity.Property(e => e.STenNcc)
                .HasMaxLength(30)
                .HasColumnName("sTenNCC");
        });

        modelBuilder.Entity<TblNhanVien>(entity =>
        {
            entity.HasKey(e => e.IMaNv).HasName("PK__tblNhanV__F20A8D79A40A2006");

            entity.ToTable("tblNhanVien");

            entity.Property(e => e.IMaNv)
                .ValueGeneratedNever()
                .HasColumnName("iMaNV");
            entity.Property(e => e.IMaCv).HasColumnName("iMaCV");
            entity.Property(e => e.SCccd)
                .HasMaxLength(30)
                .HasColumnName("sCCCD");
            entity.Property(e => e.SDiaChi)
                .HasMaxLength(200)
                .HasColumnName("sDiaChi");
            entity.Property(e => e.SGioiTinh)
                .HasMaxLength(10)
                .HasColumnName("sGioiTinh");
            entity.Property(e => e.SSdt)
                .HasMaxLength(20)
                .HasColumnName("sSDT");
            entity.Property(e => e.STenNv)
                .HasMaxLength(100)
                .HasColumnName("sTenNV");
        });

        modelBuilder.Entity<TblPhieuBaoTri>(entity =>
        {
            entity.HasKey(e => e.SMaBt).HasName("PK__tblPhieu__328E3D8222659195");

            entity.ToTable("tblPhieuBaoTri");

            entity.Property(e => e.SMaBt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sMaBT");
            entity.Property(e => e.DThoiGian)
                .HasColumnType("datetime")
                .HasColumnName("dThoiGian");
            entity.Property(e => e.IMaNv).HasColumnName("iMaNV");
            entity.Property(e => e.IMaPhuongTien).HasColumnName("iMaPhuongTien");
            entity.Property(e => e.SGhiChu)
                .HasMaxLength(100)
                .HasColumnName("sGhiChu");

            entity.HasOne(d => d.IMaNvNavigation).WithMany(p => p.TblPhieuBaoTris)
                .HasForeignKey(d => d.IMaNv)
                .HasConstraintName("FK__tblPhieuB__iMaNV__14270015");

            entity.HasOne(d => d.IMaPhuongTienNavigation).WithMany(p => p.TblPhieuBaoTris)
                .HasForeignKey(d => d.IMaPhuongTien)
                .HasConstraintName("FK__tblPhieuB__iMaPh__1332DBDC");
        });

        modelBuilder.Entity<TblPhieuNhapKho>(entity =>
        {
            entity.HasKey(e => e.IMaPhieuNhap).HasName("PK__tblPhieu__23AF4DB19C5E385D");

            entity.ToTable("tblPhieuNhapKho");

            entity.Property(e => e.IMaPhieuNhap)
                .ValueGeneratedNever()
                .HasColumnName("iMaPhieuNhap");
            entity.Property(e => e.FTongGiaNhap).HasColumnName("fTongGiaNhap");
            entity.Property(e => e.IMaNv).HasColumnName("iMaNV");
            entity.Property(e => e.IMaPhuongTien).HasColumnName("iMaPhuongTien");
            entity.Property(e => e.SMaNcc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sMaNCC");

            entity.HasOne(d => d.IMaNvNavigation).WithMany(p => p.TblPhieuNhapKhos)
                .HasForeignKey(d => d.IMaNv)
                .HasConstraintName("FK__tblPhieuN__iMaNV__18EBB532");

            entity.HasOne(d => d.IMaPhuongTienNavigation).WithMany(p => p.TblPhieuNhapKhos)
                .HasForeignKey(d => d.IMaPhuongTien)
                .HasConstraintName("FK__tblPhieuN__iMaPh__17036CC0");

            entity.HasOne(d => d.SMaNccNavigation).WithMany(p => p.TblPhieuNhapKhos)
                .HasForeignKey(d => d.SMaNcc)
                .HasConstraintName("FK__tblPhieuN__sMaNC__17F790F9");
        });

        modelBuilder.Entity<TblPhieuXuatXe>(entity =>
        {
            entity.HasKey(e => e.IMaPhieuXuat).HasName("PK__tblPhieu__EECC13AC92BAB950");

            entity.ToTable("tblPhieuXuatXe");

            entity.Property(e => e.IMaPhieuXuat)
                .ValueGeneratedNever()
                .HasColumnName("iMaPhieuXuat");
            entity.Property(e => e.FTongTien).HasColumnName("fTongTien");
            entity.Property(e => e.IMaNv).HasColumnName("iMaNV");
            entity.Property(e => e.ITongSlx).HasColumnName("iTongSLX");

            entity.HasOne(d => d.IMaNvNavigation).WithMany(p => p.TblPhieuXuatXes)
                .HasForeignKey(d => d.IMaNv)
                .HasConstraintName("FK__tblPhieuX__iMaNV__1BC821DD");
        });

        modelBuilder.Entity<TblPhuongTien>(entity =>
        {
            entity.HasKey(e => e.IMaPhuongTien).HasName("PK__tblPhuon__BAC9562E134F554D");

            entity.ToTable("tblPhuongTien");

            entity.Property(e => e.IMaPhuongTien).HasColumnName("iMaPhuongTien");
            entity.Property(e => e.FGiaChoThue).HasColumnName("fGiaChoThue");
            entity.Property(e => e.IMaLoaiPhuongTien).HasColumnName("iMaLoaiPhuongTien");
            entity.Property(e => e.SBienSoXe)
                .HasMaxLength(200)
                .HasColumnName("sBienSoXe");
            entity.Property(e => e.STenPhuongTien)
                .HasMaxLength(200)
                .HasColumnName("sTenPhuongTien");
            
            entity.Property(e => e.sDuongDan)
                .HasMaxLength(200)
                .HasColumnName("sDuongDan");

            entity.Property(e => e.sTrangThai)
                .HasColumnType("bit")
                .HasColumnName("sTrangThai");

            entity.HasOne(d => d.IMaLoaiPhuongTienNavigation).WithMany(p => p.TblPhuongTiens)
                .HasForeignKey(d => d.IMaLoaiPhuongTien)
                .HasConstraintName("FK__tblPhuong__iMaLo__0B91BA14");
        });

        modelBuilder.Entity<TblTaiKhoan>(entity =>
        {
            entity.HasKey(e => e.IMaTk).HasName("PK__tblTaiKh__F20A5E341E113505");

            entity.ToTable("tblTaiKhoan");

            entity.Property(e => e.IMaTk).HasColumnName("iMaTK");
            entity.Property(e => e.DNgayCapTk)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dNgayCapTK");
            entity.Property(e => e.IMaNv).HasColumnName("iMaNV");
            entity.Property(e => e.SMatKhau)
                .HasMaxLength(100)
                .HasColumnName("sMatKhau");
            entity.Property(e => e.STaiKhoan)
                .HasMaxLength(100)
                .HasColumnName("sTaiKhoan");

            entity.HasOne(d => d.IMaNvNavigation).WithMany(p => p.TblTaiKhoans)
                .HasForeignKey(d => d.IMaNv)
                .HasConstraintName("FK__tblTaiKho__iMaNV__03F0984C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
