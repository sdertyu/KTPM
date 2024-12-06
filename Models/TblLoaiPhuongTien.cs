using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblLoaiPhuongTien
{
    public int IMaLoaiPhuongTien { get; set; }

    public string? SLoaiPhuongTien { get; set; }

    public virtual ICollection<TblPhuongTien> TblPhuongTiens { get; set; } = new List<TblPhuongTien>();
}
