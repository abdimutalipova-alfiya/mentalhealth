using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mental_Health.Models;
using Contentful.Core;
using Contentful.Core.Models;
using Contentful.Core.Search;

namespace Mental_Health.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IContentfulClient _client;

    public HomeController(ILogger<HomeController> logger, IContentfulClient client)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var entry = await _client.GetEntriesByType<Main>("main");
        return View(entry);
    }
    public async Task<IActionResult> CourseCard()
    {
        var courses = await _client.GetEntriesByType<Course>("course");
        return View(courses);
    }

    public async Task<IActionResult> Product()
    {
        var products = await _client.GetEntriesByType<Product>("product");
        return View(products);
    }

    public async Task<IActionResult> Course(string courseId)
    {
        // Fetch the course details based on the courseId
        var course = await _client.GetEntry<Course>(courseId);


        return View(course);
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

