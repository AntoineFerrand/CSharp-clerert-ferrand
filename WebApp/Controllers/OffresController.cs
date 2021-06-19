using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiblioClass.Entity;
using BLL;
using WebApp.Models.Offres;

namespace WebApp.Controllers
{
    public class OffresController : Controller
    {
        private Manager manager;

        public OffresController()
        {
            manager = Manager.Instance;
        }

        public ActionResult Index(string searchBar)
        {
            List<Offre> offres = manager.GetOffresByContain((searchBar != null)? searchBar : "");
            List<OffreViewModel> offresVm = new List<OffreViewModel>();
            foreach (var offre in offres)
            {
                offresVm.Add(new OffreViewModel { Id = offre.Id, Intitule = offre.Intitule, Date = offre.Date });
            }

            return View(offresVm);
        }
    }
}