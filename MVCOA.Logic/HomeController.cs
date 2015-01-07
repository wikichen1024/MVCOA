using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace MVCOA.Logic
{
    public class HomeController:Controller
    {
        /// <summary>
        /// test method. retrieve all permissions
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // 1.read date through interface
            // 2.load view
            return View();
        }
    }
}
//merge to master