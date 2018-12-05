using bean;
using Service_DA.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service_DA.DataSetTableAdapters;

namespace Service_DA.services
{
    public class SDAExigence : IDAExigence
    {
        public void DeleteExigence(int p_idExigence)
        {
            new ExigenceTableAdapter().DeleteExigence(p_idExigence);
        }

        public Exigence GetExigenceById(int p_idExigence)
        {
            Exigence exigence = null;
            foreach(DataSet.ExigenceRow row in new ExigenceTableAdapter().GetExigenceById(p_idExigence))
            {
                exigence = FromDBToBean(row);
            }
            return exigence;
        }

        public List<Exigence> GetExigenceByProjetId(int p_idProjet)
        {
            List<Exigence> listExigences = new List<Exigence>();
            foreach(DataSet.ExigenceRow row in new ExigenceTableAdapter().GetExigencesByProjet(p_idProjet))
            {
                listExigences.Add(FromDBToBean(row));
            }
            return listExigences;
        }

        public int InsertExigence(Exigence p_exigence)
        {
            return new ExigenceTableAdapter().InsertExigence(p_exigence.Decription, p_exigence.Fonctionnelle, p_exigence.Type, p_exigence.Projet);
        }

        public void UpdateExigence(Exigence p_exigence)
        {
            new ExigenceTableAdapter().UpdateExigence(p_exigence.Decription, p_exigence.Fonctionnelle, p_exigence.Type, p_exigence.Projet, p_exigence.Id);
        }

        #region FromRowToBean
        private Exigence FromDBToBean(DataSet.ExigenceRow p_row)
        {
            return new Exigence(p_row.Id, p_row.Description, p_row.Fonctionnelle, p_row.Type, p_row.Projet);
        }
        #endregion
    }
}
