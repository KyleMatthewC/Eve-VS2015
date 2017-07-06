using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eevie.Controllers
{
    public class EditEvaluationFormController : Controller
    {
        // GET: EditEvaluationForm
        public ActionResult EditEvaluationForm()
        {
            return View("EditEvaluationForm");
        }
    }
}