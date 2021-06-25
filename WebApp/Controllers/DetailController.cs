using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Offres;

namespace WebApp.Controllers
{
    public class DetailController : Controller
    {
        private Manager manager;

        public DetailController()
        {
            manager = Manager.Instance;
        }

        public ActionResult Index(int id)
        {
            return View(GetOffre(id));
        }

        public ActionResult RegisterPostulation(int id)
        {
            if (GetOffre(id).HasPostuled)
            {
                manager.RemovePostulation(id);
            }
            else
            {
                manager.InsertPostulation(id);
            }
            return View(GetOffre(id));
        }

        public OffreViewModel GetOffre(int id)
        {
            Offre offre = manager.getOffre(id);
            OffreViewModel offreVm = new OffreViewModel
            {
                Id = offre.Id,
                Intitule = offre.Intitule,
                Description = offre.Description,
                Date = offre.Date,
                Salaire = offre.Salaire,
                Responsable = offre.Responsable,
                HasPostuled = manager.GetPostulationByOffreId(id) != null
            };
            return offreVm;
        }
    }
}