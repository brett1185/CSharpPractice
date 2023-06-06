using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers;

public class HomeController : Controller
{
  static HogwartsStudent NewStudent;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
[HttpGet("")]
    public IActionResult Index()
    {
    
        return View();
    }
    [HttpPost("register")]
public IActionResult Register(HogwartsStudent student) // updated
{    
 NewStudent = student;


 return RedirectToAction("Results");
} 

[HttpGet("results")]

    public IActionResult Results(){
        return View(NewStudent);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
