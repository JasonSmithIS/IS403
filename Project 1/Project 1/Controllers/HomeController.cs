//Jason Smith IS403 Fall 2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        //This returns the home page
        public ActionResult Index()
        {
            return View();
        }
        //This takes you to the main missions page where you can select a mission
        public ActionResult Missions()
        {
            return View();
        }
        //This page is where the mission information is displayed, the mission name is passed in.
        public ActionResult MissionFAQ(string name)
        {
            //I add the name to the viewbag to use later on the page
            ViewBag.name = name;
            //Here I add the file path to the mission flag
            ViewBag.image = "../Content/Images/" + name + ".png";

            //Here I set the values for each mission
            if (name == "Florida")
            {
                ViewBag.MisPres = "Mark D. Cusick";
                ViewBag.MisStAdd = "13153 N. Dale Mabry Highway Ste: 109";
                ViewBag.MisAdd = "Tampa, Florida 33618-2410";
                ViewBag.Lang = "English 82.1%, Spanish 10.7%, other Indo-European 3.8%, Asian and Pacific island 2.7%, other 0.7% (2000 census) ";
                ViewBag.Clim = "mostly temperate, but tropical in some regions";
                ViewBag.Rel = "Protestant 51.3%, Roman Catholic 23.9%, Mormon 1.7%, other Christian 1.6%, Jewish 1.7%, Buddhist 0.7%, Muslim 0.6%, other or unspecified 2.5%, unaffiliated 12.1%, none 4% (2007 est.) ";
            }
            if (name == "Tokyo")
            {
                ViewBag.MisPres = "L. Todd Budge";
                ViewBag.MisStAdd = "4-25-12 Nishi-ochiai";
                ViewBag.MisAdd = "Shinjuku-ku, Tokyo";
                ViewBag.Lang = "Japanese ";
                ViewBag.Clim = "varies from tropical in south to cool temperate in north ";
                ViewBag.Rel = "Shintoism 83.9%, Buddhism 71.4%, Christianity 2%, other 7.8% note: total adherents exceeds 100% because many people belong to both Shintoism and Buddhism (2005) ";
            }
            if (name == "Paris")
            {
                ViewBag.MisPres = "Franck Poznanski";
                ViewBag.MisStAdd = "23, Rue Du Onze Novembre";
                ViewBag.MisAdd = " 78110 Le Vesinet";
                ViewBag.Lang = "French (official) 100%, rapidly declining regional dialects and languages (Provencal, Breton, Alsatian, Corsican, Catalan, Basque, Flemish) overseas departments: French, Creole patois, Mahorian (a Swahili dialect)";
                ViewBag.Clim = "metropolitan France: generally cool winters and mild summers, but mild winters and hot summers along the Mediterranean; occasional strong, cold, dry, north-to-northwesterly wind known as mistral ";
                ViewBag.Rel = "Roman Catholic 83%-88%, Protestant 2%, Jewish 1%, Muslim 5%-10%, unaffiliated 4% overseas departments: Roman Catholic, Protestant, Hindu, Muslim, Buddhist, pagan ";
            }
            return View();
        }
        //This takes you to the about page
        public ActionResult About()
        {
            ViewBag.Message = "Mission FAQs description page.";

            return View();
        }
        //This takes you to the Contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Mission FAQs contact page.";

            return View();
        }
    }
}