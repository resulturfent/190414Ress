using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190413_ProjeV1.Areas.AdminPaneli.Controllers
{
    public class DefaultController : Controller
    {
        // GET: AdminPaneli/Default
        public ActionResult AdminIndex()
        {
            return View();
        }
    }
}