using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCommunity.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult IndexContent()
        {
            return View();
        }
    }
}