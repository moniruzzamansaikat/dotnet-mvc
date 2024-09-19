using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotnetMvc.Models;

namespace DotnetMvc.Controllers;

public class SiteController : Controller
{
    private readonly ILogger<SiteController> _logger;

    public SiteController(ILogger<SiteController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [Route("Test")]
    public IActionResult Test() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
