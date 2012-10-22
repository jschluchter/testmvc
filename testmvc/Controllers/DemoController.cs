using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAzure.Azure.Tables;

namespace testmvc.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index()
        {
            return View();
        }

        public  ActionResult Sellers()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Sellers(Seller model)
        {
            return View(model);
        }

    }
}
