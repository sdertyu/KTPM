using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblPhieuXuatXe
{
    public int IMaPhieuXuat { get; set; }

    public int? IMaNv { get; set; }

    public int? ITongSlx { get; set; }

    public double? FTongTien { get; set; }

    public virtual TblNhanVien? IMaNvNavigation { get; set; }
}
