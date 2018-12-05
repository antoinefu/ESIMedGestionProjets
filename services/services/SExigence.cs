using bean;
using Service_DA;
using services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.services
{
    public class SExigence : IExigence
    {
        public void DeleteExigence(int p_idExigence)
        {
            FactoryServiceDA.CreateServiceDAExigence().DeleteExigence(p_idExigence);
        }

        public Exigence GetExigenceById(int p_idExigence)
        {
            return FactoryServiceDA.CreateServiceDAExigence().GetExigenceById(p_idExigence);
        }

        public List<Exigence> GetExigenceByProjetId(int p_idProjet)
        {
            return FactoryServiceDA.CreateServiceDAExigence().GetExigenceByProjetId(p_idProjet);
        }

        public int InsertExigence(string p_description, bool p_fonctionnelle, int p_type, int p_projet)
        {
            return FactoryServiceDA.CreateServiceDAExigence().InsertExigence(new Exigence(0, p_description, p_fonctionnelle, p_type, p_projet));
        }

        public void UpdateExigence(int p_id, string p_description, bool p_fonctionnelle, int p_type, int p_projet)
        {
            FactoryServiceDA.CreateServiceDAExigence().UpdateExigence(new Exigence(p_id, p_description, p_fonctionnelle, p_type, p_projet));
        }
    }
}
