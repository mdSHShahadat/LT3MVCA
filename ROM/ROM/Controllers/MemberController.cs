using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROM.Controllers
{
   
    public class MemberController : Controller
    {
        
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }
    }
}