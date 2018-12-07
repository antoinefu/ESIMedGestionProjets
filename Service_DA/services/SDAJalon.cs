using bean;
using Service_DA.interfaces;
using System;
using System.Collections.Generic;
using Service_DA.DataSetTableAdapters;

namespace Service_DA.services
{
    public class SDAJalon : IDAJalon
    {
        public void DeleteJalon(int p_id)
        {
            new JalonTableAdapter().DeleteJalon(p_id);
        }

        public Jalon GetJalonById(int p_id)
        {
            Jalon jalon = null;
            foreach (DataSet.JalonRow row in new JalonTableAdapter().GetJalonById(p_id))
            {
                jalon = FromDBToBean(row);
            }
            return jalon;
        }

        public List<Jalon> GetJalonsByProjetId(int p_idProjet)
        {
            List<Jalon> listJalons = new List<Jalon>();
            foreach (DataSet.JalonRow row in new JalonTableAdapter().GetJalonsByProjet(p_idProjet))
            {
                listJalons.Add(FromDBToBean(row));
            }
            return listJalons;
        }

        public int InsertJalon(Jalon p_jalon)
        {
            return new JalonTableAdapter().InsertJalon(p_jalon.Nom, p_jalon.Responsable, p_jalon.DateLivraisonPrevue, default(DateTime), p_jalon.Projet);
        }

        public void UpdateJalon(Jalon p_jalon)
        {
            new JalonTableAdapter().UpdateJalon(p_jalon.Nom, p_jalon.Responsable, p_jalon.DateLivraisonPrevue, p_jalon.DateLivraisonReelle, p_jalon.Projet, p_jalon.Id);
        }

        #region FromRowToBean
        private Jalon FromDBToBean(DataSet.JalonRow p_row)
        {
            return new Jalon(p_row.Id, p_row.Nom, p_row.Responsable, p_row.DateLivraisonPrevue, p_row.DateLivraisonReelle, p_row.Projet);
        }
        #endregion
    }
}
