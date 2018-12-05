using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface IExigence
    {
        List<Exigence> GetExigenceByProjetId(int p_idProjet);

        Exigence GetExigenceById(int p_idExigence);

        int InsertExigence(string p_description, bool p_fonctionnelle, int p_type, int p_projet);

        void UpdateExigence(int p_id, string p_description, bool p_fonctionnelle, int p_type, int p_projet);

        void DeleteExigence(int p_idExigence);
    }
}
