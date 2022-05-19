using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comments_challenge.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index(int id)
        {
            Response.StatusCode = id;

            return View();
        }
    }
}
