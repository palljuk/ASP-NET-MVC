using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();


        }

        [HttpPost]
        public ActionResult Index(FormCollection input)
        {
            StreamReader sr = new StreamReader(Request.InputStream);
            string json = sr.ReadToEnd();
            Name name = JsonConvert.DeserializeObject<Name>(json);

            FirstProjectEntities entities = new FirstProjectEntities();
            SafetyBriefings s = new SafetyBriefings();
            s.CustomerName = name.CustomerName;
            s.CreatedAt = DateTime.Now;
            entities.SafetyBriefings.Add(s);
            entities.SaveChanges();


            return View();

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}