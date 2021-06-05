using BiblioClass;
using BiblioClass.Entity;
using BLL.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager
    {
        private static Manager _instance;

        private Manager() {}

        public static Manager Instance
        {
            get {
                if (_instance == null) { _instance = new Manager(); }
                return _instance;
            }
        }

        public List<Offre> GetAllOffres()
        {
            return new OffreQuery().Offres.ToList();
        }

        public void AddOffre(Offre o)
        {
            MonContexte _contexte = new MonContexte();
            _contexte.Offres.Add(o);
            _contexte.SaveChanges();
        }

        public void AddStatut(Statut s)
        {
            MonContexte _contexte = new MonContexte();
            _contexte.Statuts.Add(s);
            _contexte.SaveChanges();
        }
    }
}
