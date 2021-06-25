using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Offres;

namespace WebApp.Models.Postulation
{
    public class PostulationViewModel
    {
        public string Date { get; set; }
        public string Statut { get; set; }
        public int OffreId { get; set; }
    }
}