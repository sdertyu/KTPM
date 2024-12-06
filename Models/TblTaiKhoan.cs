using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblTaiKhoan
{
    public int IMaTk { get; set; }

    public string? STaiKhoan { get; set; }

    public string? SMatKhau { get; set; }

    public int? IMaNv { get; set; }

    public DateTime? DNgayCapTk { get; set; }

    public virtual TblNhanVien? IMaNvNavigation { get; set; }
}
