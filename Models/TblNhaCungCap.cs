using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblNhaCungCap
{
    public string SMaNcc { get; set; } = null!;

    public string? STenNcc { get; set; }

    public virtual ICollection<TblPhieuNhapKho> TblPhieuNhapKhos { get; set; } = new List<TblPhieuNhapKho>();
}
