using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using Microsoft.Extensions.Configuration;

namespace FinalProject.Controllers;

public class HomeController : Controller
{
   // private readonly IConfiguration _configuration;

    //public HomeController(IConfiguration configuration)
    //{
       // _configuration = configuration;
    //}

    //public JsonResult GetAPIData(string param)
    //{
        //var authKey = _configuration.GetValue<string>("AuthKey");
       // var league = _configuration.GetSection("Api:League").Value;

        
      
    //}

    private readonly ILogger<HomeController> _logger;
 

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
   
    public IActionResult Index()
    {
        return View();
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

