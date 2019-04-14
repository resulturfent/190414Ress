using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190413_ProjeV1.Controllers
{
    public class EtiketlerController : Controller
    {
        // GET: Etiketler
        public ActionResult EtiketlerListesiIndex()
        {
            return View();
        }
    }
}