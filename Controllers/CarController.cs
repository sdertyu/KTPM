using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using thueOTo.Models;

namespace thueOTo.Controllers;

public class CarController : Controller
{
    private readonly CarService _carService;

    public CarController(CarService customerService)
    {
        _carService = customerService;
    }

    [Route("dsCar")]
    public IActionResult Index() {
        List<TblPhuongTien> list = _carService.getAllCar();
        TempData["listCar"] = list;
        return View();
    }

    [Route("carDetail/{id?}")]
    public IActionResult CarDetail(int id) {
        TblPhuongTien car = _carService.getCarById(id);
        return View(car);
    }

    [Route("carDetail/{id?}")]
    [HttpPost]
    public IActionResult ThueXe(int id) {
        _carService.thueXe(id);
        TempData["message"] = "Thuê xe thành công, hãy vào giỏ hàng để xem";
        return RedirectToAction("CarDetail", "Car", new { id = id }); // Chuyen huong den CarDetail(id);
    }
}