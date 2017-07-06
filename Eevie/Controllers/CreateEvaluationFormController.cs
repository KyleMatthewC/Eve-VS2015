using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevie.Controllers
{
    public class CreateEvaluationFormController : Controller
    {
        // GET: CreateEvaluationForm
        public ActionResult CreateEvaluationForm()
        {
            return View("CreateEvaluationForm");
        }
    }
}