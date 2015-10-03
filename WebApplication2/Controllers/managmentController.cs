using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class managmentController : Controller
    {
        //
        // GET: /managment/
        public ActionResult Index()
        {
            return View();
        }  

        [Authorize (Roles = "Administrator")]
        public ActionResult Manage()
        {
            return View();
          }
                
	}
}