using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;
using BaiThucHanh2002.Models.Process;

namespace BaiThucHanh2002.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            //gui du lieu ve view
            ViewBag.thongbao = strReturn;
            return View();
            //tra ve danh sach cac sinh vien trong Database
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            string kq = emp.EmployeeCode + "-" + emp.EmployeeName + "- " + emp.Address;
            ViewBag.mess = kq;
            return View(); 
        }
    }

}