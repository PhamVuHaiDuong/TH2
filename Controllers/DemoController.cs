using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH2.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult TinhTong()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhTong(string SoA, string SoB)
        {
            //chuyen doi kieu du lieu cau 2 tham so gui tu client len sever
            double So1 = Convert.ToDouble(SoA);
            double So2 = Convert.ToDouble(SoB);
            //tinh tong 2 so
            double tong = So1 + So2;
            //su dung viewbag de gui du lieu tu sever ve client
            ViewBag.TongHaiSo = tong;
            return View();
        }
    }
}