using SieuThi.Bussiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SieuThi.Models.Home;

namespace WebsiteDemo.Controllers
{
    public class HomeController : Controller
    {
        IHomeServices _HomeServices { get; set; }
        public HomeController(IHomeServices homeServices)
        {
            _HomeServices = homeServices;
        }
        public ActionResult Index()
        {
            
            ViewBag.Title2 = "Hệ thống nhu yếu phẩm cực vip pro!";
            return View(_HomeServices.MatHangListSelect());
        }

        public ActionResult GetMatHangList()
        {
            ViewBag.Title2 = "Get Thành Công!";
            return View("_PartialMatHangList", _HomeServices.MatHangListSelect());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}