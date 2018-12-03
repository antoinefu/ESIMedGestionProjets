using bean;
using Service_DA.interfaces;
using System;
using System.Collections.Generic;
using Service_DA.DataSetTableAdapters;

namespace Service_DA.services
{
    public class SDAProjet : IDAProjet
    {
        public void DeleteProjet(int p_id)
        {
            new ProjetTableAdapter().DeleteProjet(p_id);
        }

        public List<Projet> GetAllProjets()
        {
            List<Projet> listProjets = new List<Projet>();
            foreach(DataSet.ProjetRow row in new ProjetTableAdapter().GetAllProjets())
            {
                listProjets.Add(FromDBToBean(row));
            }
            return listProjets;
        }

        public Projet GetProjetById(int p_id)
        {
            Projet projet = null;
            foreach (DataSet.ProjetRow row in new ProjetTableAdapter().GetProjetById(p_id))
            {
                projet = FromDBToBean(row);
            }
            return projet;
        }

        public int NewProjet(Projet p_projet)
        {
            return new ProjetTableAdapter().InsertProjet(p_projet.Nom, p_projet.Trigramme, p_projet.Responsable, p_projet.DateDebut, p_projet.DateFinPrevue);
        }

        public int UpdateProjet(Projet p_projet)
        {
            return new ProjetTableAdapter().UpdateProjet(p_projet.Nom, p_projet.Trigramme, p_projet.Responsable, p_projet.DateDebut, p_projet.DateFinPrevue, p_projet.Id);
        }

        #region FromRowToBean
        private Projet FromDBToBean(DataSet.ProjetRow p_row)
        {
            return new Projet(p_row.Id, p_row.Nom, p_row.Trigramme, p_row.Responsable, p_row.DateDebut, p_row.DateFinPrevue);
        }
        #endregion
    }
}
