using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Home()
        {


            return View();
        }
        public ActionResult About()
        {
      
            ViewBag.Name = "MD ABU BAKAR SIDDIQUE";
            ViewBag.Title = "Studies BSc in CSE, AIUB";
            ViewBag.Phone = "01256987456";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Email = "abcd@gmail.com";
            ViewBag.Phone = "01236985478";
            ViewBag.Address = "Kuril, Dhaka";
            return View();
        }
         
        public ActionResult Education()
        {
            Education[] e =new Education[3];
            e[0] = new Education();
            e[1] = new Education();
            e[2] = new Education();

            e[0].Title = "SSC";
            e[0].Institute = "KD High School";
            e[0].Result = 4.44f;

            e[1].Title = "HSC";
            e[1].Institute = "Govt.  College";
            e[1].Result = 5.00f;

            e[2].Title = "BSc in Computer Science and Engineering";
            e[2].Institute = "American International University-Bangladesh (AIUB)";
            e[2].Result = 3.70f;


            return View(e);
        }
        public ActionResult Project()
        {
            Project[] p = new Project[5];
            p[0] = new Project();
            p[1] = new Project();
            p[2] = new Project();
            p[3] = new Project();
            p[4] = new Project();

            p[0].Title = "AgriConnect";
            p[0].Course = "Web Technology";
            p[0].Description = "A web-based platform that connects farmers directly with buyers to sell agricultural products online efficiently.";

            p[1].Title = "GovtAid";
            p[1].Course = "C# Programming";
            p[1].Description = "A service platform that helps general users access government-related services easily with the help of verified brokers.";

            p[2].Title = "Student Management System";
            p[2].Course = "Java Programming";
            p[2].Description = "A desktop application designed for managing student information, attendance, and results for American International School.";

            p[3].Title = "Smart Pet Feeder";
            p[3].Course = "IoT Project";
            p[3].Description = "An IoT-based pet feeding system using ESP32-CAM for real-time monitoring and scheduled feeding via a web interface.";

            p[4].Title = "Crafty SRS";
            p[4].Course = "Software Requirement Engineering";
            p[4].Description = "A detailed Software Requirements Specification (SRS) document for an online crafting marketplace, focusing on system analysis, functional requirements, and use case modeling.";


            return View(p);
        }

    

    }
}