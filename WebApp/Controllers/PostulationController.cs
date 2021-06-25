using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Postulation;

namespace WebApp.Controllers
{
    public class PostulationController : Controller
    {
        private Manager manager;

        public PostulationController()
        {
            manager = Manager.Instance;
        }

        public ActionResult Index()
        {
            List<Postulation> postulations = manager.GetPostulationByEmployeId(5);
            List<PostulationViewModel> postulationsVm = new List<PostulationViewModel>();
            foreach (var postulation in postulations)
            {
                postulationsVm.Add(new PostulationViewModel
                {
                    Date = postulation.Date,
                    Statut = postulation.Statut,
                    OffreId = postulation.OffreId
                });
            }

            return View(postulationsVm);
        }
    }
}