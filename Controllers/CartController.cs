using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using thueOTo.Models;

namespace thueOTo.Controllers;

public class CartController : Controller
{
    private readonly CartService _cartService;

    public CartController(CartService customerService)
    {
        _cartService = customerService;
    }

    [Route("cart")]
    public IActionResult Index()
    {
        List<TblPhuongTien> list = _cartService.getAllCart();
        TempData["listCar"] = list;
        return View();
    }

}