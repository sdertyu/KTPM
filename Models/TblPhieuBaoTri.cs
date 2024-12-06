using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblPhieuBaoTri
{
    public string SMaBt { get; set; } = null!;

    public int? IMaPhuongTien { get; set; }

    public string? SGhiChu { get; set; }

    public int? IMaNv { get; set; }

    public DateTime? DThoiGian { get; set; }

    public virtual TblNhanVien? IMaNvNavigation { get; set; }

    public virtual TblPhuongTien? IMaPhuongTienNavigation { get; set; }
}
