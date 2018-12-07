using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface IJalon
    {
        List<Jalon> GetJalonByProjetId(int p_idProjet);

        Jalon GetJalonById(int p_id);

        int InsertJalon(int p_id, string p_nom, int p_responsable, DateTime p_dateLivraisonPrevue, DateTime p_dateLivraisonReelle, int p_projet);

        void UpdateJalon(int p_id, string p_nom, int p_responsable, DateTime p_dateLivraisonPrevue, DateTime p_dateLivraisonReelle, int p_projet);

        void DeleteJalon(int p_id);
    }
}
