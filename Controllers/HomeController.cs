using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    
        return View();
    }
    [HttpPost("register")]
public IActionResult RegisterWizard(HogwartsStudent student) // updated
{    
 Console.WriteLine(student.Name);
 Console.WriteLine(student.House);
 Console.WriteLine(student.CurrentYear);
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
