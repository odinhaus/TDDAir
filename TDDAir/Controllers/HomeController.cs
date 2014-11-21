using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highway.Data;
using Highway.Data.Repositories;
using TDDAir.Data.Logic;
using TDDAir.Data.Queries;
using TDDAir.Models;

namespace TDDAir.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var tddAir = new TDDAir.Data.TDDAir(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            var context = new DomainContext<TDDAir.Data.TDDAir>(tddAir);
            IRepository repo = new DomainRepository<TDDAir.Data.TDDAir>(context, tddAir);

            var query = new FlierByUserName(System.Threading.Thread.CurrentPrincipal.Identity.Name, new FlierLogic());
            ViewBag.Flier = repo.Find(query);
            if (ViewBag.Flier != null)
            {
                var flightsQuery = new FlightsByFlierId(ViewBag.Flier.Id, new FlightLogic());
                ViewBag.Flights = repo.Find(flightsQuery);
            }
            else ViewBag.Flights = null;

            if (ViewBag.Flier == null)
            {
                // redirect to login
                return Redirect("Account/Login");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
