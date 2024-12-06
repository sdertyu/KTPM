using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblNhanVien
{
    public int IMaNv { get; set; }

    public int? IMaCv { get; set; }

    public string? STenNv { get; set; }

    public string? SSdt { get; set; }

    public string? SGioiTinh { get; set; }

    public string? SCccd { get; set; }

    public string? SDiaChi { get; set; }

    public virtual ICollection<TblHoaDon> TblHoaDons { get; set; } = new List<TblHoaDon>();

    public virtual ICollection<TblPhieuBaoTri> TblPhieuBaoTris { get; set; } = new List<TblPhieuBaoTri>();

    public virtual ICollection<TblPhieuNhapKho> TblPhieuNhapKhos { get; set; } = new List<TblPhieuNhapKho>();

    public virtual ICollection<TblPhieuXuatXe> TblPhieuXuatXes { get; set; } = new List<TblPhieuXuatXe>();

    public virtual ICollection<TblTaiKhoan> TblTaiKhoans { get; set; } = new List<TblTaiKhoan>();
}
