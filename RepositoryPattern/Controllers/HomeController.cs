using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;
using RepositoryPattern.Service;
using System.Diagnostics;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeServices _employServices;
        private readonly IEmployee _employee;
        public HomeController(IEmployeeServices employServices, IEmployee employee)
        {
            _employServices = employServices;
            _employee = employee;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employee.GetAll();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employServices.SaveEmployee(employee);
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}