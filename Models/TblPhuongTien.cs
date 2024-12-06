using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace thueOTo.Models;

public partial class TblPhuongTien
{
    public int IMaPhuongTien { get; set; }

    public string? STenPhuongTien { get; set; }

    public int? IMaLoaiPhuongTien { get; set; }

    public double? FGiaChoThue { get; set; }

    public string? SBienSoXe { get; set; }

    public string? sDuongDan { get; set; }

    public bool? sTrangThai { get; set; }

    public virtual TblLoaiPhuongTien? IMaLoaiPhuongTienNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<TblHoaDon> TblHoaDons { get; set; } = new List<TblHoaDon>();

    public virtual ICollection<TblPhieuBaoTri> TblPhieuBaoTris { get; set; } = new List<TblPhieuBaoTri>();
    [JsonIgnore]
    public virtual ICollection<TblPhieuNhapKho> TblPhieuNhapKhos { get; set; } = new List<TblPhieuNhapKho>();
}
