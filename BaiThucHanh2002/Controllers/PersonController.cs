using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;
using BaiThucHanh2002.Models.Process;
namespace BaiThucHanh2002.Controllers;

    public class PersonController : Controller
    {
    public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string trave = std.EmployeeCode + "-" + std.EmployeeName + "- " + std.Address;
            ViewBag.m = trave;
            return View();
        }
    }
