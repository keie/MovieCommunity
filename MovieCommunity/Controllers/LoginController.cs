﻿
namespace MovieCommunity.Controllers
{
    using MovieCommunity.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    

    public class LoginController : Controller
    {
        
        
        // GET: Login
        public ActionResult Index()
        {
            
            
            return View();
        }

        public bool Login()
        {
            bool ans = false;
            long l = Request.InputStream.Length;

            return ans;
        }

        
        
    }
}