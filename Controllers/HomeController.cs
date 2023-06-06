using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers;

public class HomeController : Controller
{
  static HogwartsStudent student;
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
public IActionResult Register(HogwartsStudent newStudent) // updated
{    
 newStudent = student;


 return RedirectToAction("Results");
} 

[HttpGet("results")]

    public IActionResult Results(){
        return View(student);
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
