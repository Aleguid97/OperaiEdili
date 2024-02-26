using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Operai.Models; // Don't forget to include the namespace of your Operai class

namespace Operai.Controllers
{
    public class OperaiController : Controller
    {
        // GET: Operai
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
           
            return View();
        }
    }
}
