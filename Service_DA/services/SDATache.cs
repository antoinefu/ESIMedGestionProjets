using bean;
using Service_DA.interfaces;
using System;
using System.Collections.Generic;
using Service_DA.DataSetTableAdapters;

namespace Service_DA.services
{
    public class SDATache : IDATache
    {
        public List<Tache> GetTachesByIdJalon(int p_idJalon)
        {
            List<Tache> listTaches = new List<Tache>();
            foreach (DataSet.TacheRow row in new TacheTableAdapter().GetTachesByJalonId(p_idJalon))
            {
                listTaches.Add(FromDBToBean(row));
            }
            return listTaches;
        }

        #region FromRowToBean
        private Tache FromDBToBean(DataSet.TacheRow p_row)
        {
            return new Tache(p_row.Id, p_row.Nom, p_row.Description, p_row.Responsable, p_row.DateDebutPrevue, p_row.DateDebutReelle, p_row.DateFin, 
                p_row.Charge, p_row.TachePrecedente, p_row.Jalon);
        }
        #endregion
    }
}
