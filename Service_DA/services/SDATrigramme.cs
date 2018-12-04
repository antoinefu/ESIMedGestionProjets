using Service_DA.interfaces;
using bean;
using System;
using Service_DA.DataSetTableAdapters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.services
{
    public class SDATrigramme : IDATrigramme
    {
        public List<Trigramme> GetAllTrigrammes()
        {
            List<Trigramme> listTrigrammes = new List<Trigramme>();
            foreach (DataSet.TrigrammeRow trigramme in new TrigrammeTableAdapter().GetAllTrigrammes())
            {
                listTrigrammes.Add(FromDBToBean(trigramme));
            }
            return listTrigrammes;
        }

        public Trigramme GetTrigrammeById(int p_id)
        {
            Trigramme trigramme = null;
            foreach (DataSet.TrigrammeRow row in new TrigrammeTableAdapter().GetTrigrammeById(p_id))
            {
                trigramme = FromDBToBean(row);
            }
            return trigramme;
        }

        public bool IfTrigrammeExisting(string p_nom)
        {
            if (new TrigrammeTableAdapter().IfExisting(p_nom).Count != 0)
                return true;
            else
                return false;
        }

        public int NewTrigramme(Trigramme p_trigramme)
        {
            return new TrigrammeTableAdapter().NewTrigramme(p_trigramme.Nom);
        }

        #region FromRowToBean
        private Trigramme FromDBToBean(DataSet.TrigrammeRow p_row)
        {
            Trigramme v_trigramme = new Trigramme(p_row.Id, p_row.Nom);

            return v_trigramme;
        }
        #endregion
    }
}
