using System;
using bean;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.interfaces
{
    public interface IDAProjet
    {
        List<Projet> GetAllProjets();

        Projet GetProjetById(int p_id);

        int NewProjet(Projet p_projet);

        void DeleteProjet(int p_id);

        int UpdateProjet(Projet p_projet);
    }
}
