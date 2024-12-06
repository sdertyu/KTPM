using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using thueOTo.data;
using thueOTo.Models;

public class CarService
{
    private readonly QuanLyThueXeContext _context;

    public CarService(QuanLyThueXeContext context)
    {
        _context = context;
    }

    public List<TblPhuongTien> getAllCar()
    {
        return _context.TblPhuongTiens.Include(c => c.IMaLoaiPhuongTienNavigation).ToList();
    }

    public TblPhuongTien getCarById(int id)
    {
        var car = _context.TblPhuongTiens
            .Include(c => c.TblPhieuBaoTris)  // Bao gồm các bản ghi liên quan trong TblPhieuBaoTri
            .Include(c => c.IMaLoaiPhuongTienNavigation)  // Bao gồm thông tin loại phương tiện liên quan
            .FirstOrDefault(c => c.IMaPhuongTien == id);  // Lấy bản ghi theo id

        return car;
    }

    public void thueXe(int id) {
        var car =_context.TblPhuongTiens.FirstOrDefault(c => c.IMaPhuongTien == id);
        car.sTrangThai = true;
        _context.SaveChanges();
    }



}