using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblPhieuNhapKho
{
    public int IMaPhieuNhap { get; set; }

    public int? IMaPhuongTien { get; set; }

    public double? FTongGiaNhap { get; set; }

    public string? SMaNcc { get; set; }

    public int? IMaNv { get; set; }

    public virtual TblNhanVien? IMaNvNavigation { get; set; }

    public virtual TblPhuongTien? IMaPhuongTienNavigation { get; set; }

    public virtual TblNhaCungCap? SMaNccNavigation { get; set; }
}
