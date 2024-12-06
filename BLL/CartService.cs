using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using thueOTo.data;
using thueOTo.Models;

public class CartService
{
    private readonly QuanLyThueXeContext _context;

    public CartService(QuanLyThueXeContext context)
    {
        _context = context;
    }

    public List<TblPhuongTien> getAllCart()
    {
        return _context.TblPhuongTiens
               .Include(c => c.IMaLoaiPhuongTienNavigation)
               .Where(c => c.sTrangThai == true)  // Câu này đã đúng nếu 'sTrangThai' là boolean
               .ToList();

    }



}