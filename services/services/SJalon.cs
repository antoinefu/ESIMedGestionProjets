using bean;
using Service_DA;
using services.interfaces;
using System;
using System.Collections.Generic;

namespace services.services
{
    public class SJalon : IJalon
    {
        public void DeleteJalon(int p_id)
        {
            FactoryServiceDA.CreateServiceDAJalon().DeleteJalon(p_id);
        }

        public Jalon GetJalonById(int p_id)
        {
            return FactoryServiceDA.CreateServiceDAJalon().GetJalonById(p_id);
        }

        public List<Jalon> GetJalonByProjetId(int p_idProjet)
        {
            return FactoryServiceDA.CreateServiceDAJalon().GetJalonsByProjetId(p_idProjet);
        }

        public int InsertJalon(int p_id, string p_nom, int p_responsable, DateTime p_dateLivraisonPrevue, DateTime p_dateLivraisonReelle, int p_projet)
        {
            return FactoryServiceDA.CreateServiceDAJalon().InsertJalon(new Jalon(p_id, p_nom, p_responsable, p_dateLivraisonPrevue, p_dateLivraisonReelle, p_projet));
        }

        public void UpdateJalon(int p_id, string p_nom, int p_responsable, DateTime p_dateLivraisonPrevue, DateTime p_dateLivraisonReelle, int p_projet)
        {
            throw new NotImplementedException();
        }
    }
}
