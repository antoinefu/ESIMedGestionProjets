using bean;
using services.interfaces;
using System;
using System.Collections.Generic;
using Service_DA;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.services
{
    public class SProjet : IProjet
    {
        public void DeleteProjet(int p_id)
        {
            FactoryServiceDA.CreateServiceDAProjet().DeleteProjet(p_id);
        }

        public List<Projet> GetAllProjets()
        {
            return FactoryServiceDA.CreateServiceDAProjet().GetAllProjets();
        }

        public Projet GetProjetById(int p_id)
        {
            return FactoryServiceDA.CreateServiceDAProjet().GetProjetById(p_id);
        }

        public int NewProjet(string p_nom, string p_trigramme, int p_responsable, DateTime p_dateDebut, DateTime p_dateFinPrevue)
        {
            return FactoryServiceDA.CreateServiceDAProjet().NewProjet(new Projet(0, p_nom, p_trigramme, p_responsable, p_dateDebut, p_dateFinPrevue));
        }

        public int UpdateProjet(string p_nom, string p_trigramme, int p_responsable, DateTime p_dateDebut, DateTime p_dateFinPrevue, int p_id)
        {
            return FactoryServiceDA.CreateServiceDAProjet().UpdateProjet(new Projet(p_id, p_nom, p_trigramme, p_responsable, p_dateDebut, p_dateFinPrevue));
        }
    }
}
