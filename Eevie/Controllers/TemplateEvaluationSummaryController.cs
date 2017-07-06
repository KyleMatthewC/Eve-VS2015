using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevie.Controllers
{
    public class TemplateEvaluationSummaryController : Controller
    {
        // GET: TemplateEvaluationSummary
        public ActionResult Summary()
        {
            return View("TemplateEvaluationSummary");
        }
    }
}