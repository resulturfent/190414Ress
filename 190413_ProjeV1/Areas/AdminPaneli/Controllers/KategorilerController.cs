using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190413_ProjeV1.Areas.AdminPaneli.Controllers
{
    public class KategorilerController : Controller
    {
        // GET: AdminPaneli/Kategoriler
        public ActionResult KategoriListesiIndex()
        {
            return View();
        }
    }
}