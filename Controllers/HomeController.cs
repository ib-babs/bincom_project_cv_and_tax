using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCV.Models;

namespace MyCV.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        return View(CV.cv());
    }

    [HttpGet]
    public IActionResult TaxCalculation()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult TaxCalculation(TaxCalculationModel tax)
    {
        if (ModelState.IsValid){
            return View(tax);
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
