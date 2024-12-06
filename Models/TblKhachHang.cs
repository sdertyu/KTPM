using System;
using System.Collections.Generic;

namespace thueOTo.Models;

public partial class TblKhachHang
{
    public int IMaKh { get; set; }

    public string? STenKh { get; set; }

    public string? SSdt { get; set; }

    public string? SGioiTinh { get; set; }

    public string? SCccd { get; set; }

    public string? SDiaChi { get; set; }

    public virtual ICollection<TblHoaDon> TblHoaDons { get; set; } = new List<TblHoaDon>();
}
