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

        public bool IfIdentifiantExisting(int p_idProjet, string p_identifiantExigence)
        {
            return FactoryServiceDA.CreateServiceDAExigence().IfIdentifiantExisting(p_idProjet, p_identifiantExigence);
        }

        public int InsertExigence(string p_identifiant, string p_description, int p_type, int p_projet)
        {
            return FactoryServiceDA.CreateServiceDAExigence().InsertExigence(new Exigence(0, p_identifiant, p_description, p_type, p_projet));
        }

        public void UpdateExigence(int p_id, string p_identifiant, string p_description, int p_type, int p_projet)
        {
            FactoryServiceDA.CreateServiceDAExigence().UpdateExigence(new Exigence(p_id, p_identifiant, p_description, p_type, p_projet));
        }
    }
}
