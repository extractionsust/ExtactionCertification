using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtractionCertification.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(string lastextract)
        {
            if (lastextract == "yes")
            {               
                return RedirectToAction("Index","Home");
            }
            else
            {
                if(lastextract =="no" )
                return View("PanelProject");
                else
                {
                    return View();
                }
            }
           
        }

       
        public ActionResult PanelProject( )
        {
           
            return View();
        }
        public ActionResult Library()
        {

            return View();
        }
        public ActionResult redirection()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}
