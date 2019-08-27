using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCommunity.Controllers
{
    public class CommunityController : Controller
    {
        // GET: Community
        public ActionResult IndexCommunity()
        {
            return View();
        }
    }
}