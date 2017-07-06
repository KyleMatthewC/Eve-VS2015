using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevie.Controllers
{
    public class SigninController : Controller
    {
        // GET: Default
        public ActionResult Signin()
        {
            return View("Signin");
        }
    }
}