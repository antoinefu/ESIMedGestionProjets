using bean;
using Service_DA.interfaces;
using Service_DA.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.services
{
    public class SDATypeExigence : IDATypeExigence
    {
        public List<TypeExigence> GetAllTypeExigences()
        {
            List<TypeExigence> listTypeExigences = new List<TypeExigence>();
            foreach (DataSet.TypeExigenceRow typeExigence in new TypeExigenceTableAdapter().GettAllTypeExigences())
            {
                listTypeExigences.Add(FromDBToBean(typeExigence));
            }
            return listTypeExigences;
        }

        #region FromRowToBean
        private TypeExigence FromDBToBean(DataSet.TypeExigenceRow p_row)
        {
            TypeExigence v_salle = new TypeExigence(p_row.id, p_row.label);

            return v_salle;
        }
        #endregion
    }
}
