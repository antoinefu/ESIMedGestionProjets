using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.interfaces
{
    public interface IDAExigence
    {
        List<Exigence> GetExigenceByProjetId(int p_idProjet);

        Exigence GetExigenceById(int p_idExigence);

        int InsertExigence(Exigence p_exigence);

        void UpdateExigence(Exigence p_exigence);

        void DeleteExigence(int p_idExigence);

        bool IfIdentifiantExisting(int p_idProjet, string p_identifiantExigence);
    }
}
