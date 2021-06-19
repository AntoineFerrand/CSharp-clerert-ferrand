using BiblioClass.Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models.Offres
{
    public class OffreViewModel
    {
        public int Id { get; set; }
        public string Intitule { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Salaire { get; internal set; }
        public string Responsable { get; internal set; }
    }
}