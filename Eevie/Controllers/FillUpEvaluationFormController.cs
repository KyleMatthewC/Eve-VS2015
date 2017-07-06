using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevie.Controllers
{
    public class FillUpEvaluationFormController : Controller
    {
        // GET: FillUpEvaluation
        public ActionResult NewEvaluation()
        {
            return View("FillUpEvaluationForm");
        }
    }
}