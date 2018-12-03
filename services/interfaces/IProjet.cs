using System;
using bean;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface IProjet
    {
        List<Projet> GetAllProjets();

        Projet GetProjetById(int p_id);

        int NewProjet(string p_nom, string p_trigramme, int p_responsable, DateTime p_dateDebut, DateTime p_dateFinPrevue);

        void DeleteProjet(int p_id);

        int UpdateProjet(string p_nom, string p_trigramme, int p_responsable, DateTime p_dateDebut, DateTime p_dateFinPrevue, int p_id);

    }
}
