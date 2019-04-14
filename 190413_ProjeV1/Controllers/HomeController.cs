using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _190413_ProjeV1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomeIndex()
        {
            return View();
        }

        
        //******************************************************************
        Models.ProjeBlogDBEntities db = new Models.ProjeBlogDBEntities();
        //******************************************************************

        public ActionResult PartialKategoriListesi()
        {
            //Sadece liste yapacak bir kısım bize lazım olacağından Partial yaptık
            return View(db.Kategoriler.ToList());
        }
    }
}