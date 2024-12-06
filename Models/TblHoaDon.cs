using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblHoaDon
{
    public int IMaHoaDon { get; set; }

    public int? IMaNv { get; set; }

    public int? IMaKh { get; set; }

    public int? IPhuongTien { get; set; }

    public DateTime? DNgayTra { get; set; }

    public DateTime? DNgayThue { get; set; }

    public double? FTienCoc { get; set; }

    public double? FTienThue { get; set; }

    public virtual TblKhachHang? IMaKhNavigation { get; set; }

    public virtual TblNhanVien? IMaNvNavigation { get; set; }

    public virtual TblPhuongTien? IPhuongTienNavigation { get; set; }
}
