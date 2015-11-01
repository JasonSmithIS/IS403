using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Missions()
        {
            return View();
        }
        public ActionResult MissionFAQ(string name)
        {
            ViewBag.name = name;
            ViewBag.image = "../Content/Images/" + name + ".png";

            if (name == "Florida")
            {
                ViewBag.MisPres = "Mark D. Cusick";
                ViewBag.MisAdd = "";
                ViewBag.Lang = "English 82.1%, Spanish 10.7%, other Indo-European 3.8%, Asian and Pacific island 2.7%, other 0.7% (2000 census) ";
                ViewBag.Clim = "mostly temperate, but tropical in some regions";
                ViewBag.Rel = "Protestant 51.3%, Roman Catholic 23.9%, Mormon 1.7%, other Christian 1.6%, Jewish 1.7%, Buddhist 0.7%, Muslim 0.6%, other or unspecified 2.5%, unaffiliated 12.1%, none 4% (2007 est.) ";
            }
            if (name == "Tokyo")
            {
                ViewBag.MisPres = "L. Todd Budge";
                ViewBag.MisAdd = "";
                ViewBag.Lang = "Japanese ";
                ViewBag.Clim = "varies from tropical in south to cool temperate in north ";
                ViewBag.Rel = "Shintoism 83.9%, Buddhism 71.4%, Christianity 2%, other 7.8% note: total adherents exceeds 100% because many people belong to both Shintoism and Buddhism (2005) ";
            }
            if (name == "Paris")
            {
                ViewBag.MisPres = "Franck Poznanski";
                ViewBag.MisAdd = "";
                ViewBag.Lang = "French (official) 100%, rapidly declining regional dialects and languages (Provencal, Breton, Alsatian, Corsican, Catalan, Basque, Flemish) overseas departments: French, Creole patois, Mahorian (a Swahili dialect)";
                ViewBag.Clim = "metropolitan France: generally cool winters and mild summers, but mild winters and hot summers along the Mediterranean; occasional strong, cold, dry, north-to-northwesterly wind known as mistral ";
                ViewBag.Rel = "Roman Catholic 83%-88%, Protestant 2%, Jewish 1%, Muslim 5%-10%, unaffiliated 4% overseas departments: Roman Catholic, Protestant, Hindu, Muslim, Buddhist, pagan ";
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact page.";

            return View();
        }
    }
}