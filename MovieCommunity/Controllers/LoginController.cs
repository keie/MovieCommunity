
namespace MovieCommunity.Controllers
{
    using BusinessRules.User;
    using MovieCommunity.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;
    using System.Web.Mvc;
    

    public class LoginController : Controller
    {
        
        
        // GET: Login
        public ActionResult Index()
        {
            
            
            return View();
        }

        public string Login()
        {
            string ans = "";
            long l = Request.InputStream.Length;
            try
            {
                if (l > 0)
                {
                    byte[] buffer = new byte[l];
                    Request.InputStream.Read(buffer, 0, (int)l);
                    var data = (Encoding.Default.GetString(buffer)).Split(',');
                    Entity.Login log = new Entity.Login(
                                        data[0],
                                        data[1]
                                             );
                    BrUser brUser = new BrUser();
                    ans = brUser.Login(log);

                }
            }
            catch(Exception e)
            {
                return e.Message;
            }

            return ans;
        }

        
        
    }
}