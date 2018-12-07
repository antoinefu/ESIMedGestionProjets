using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.interfaces
{
    public interface IDAJalon
    {
        List<Jalon> GetJalonsByProjetId(int p_idProjet);

        Jalon GetJalonById(int p_id);

        void DeleteJalon(int p_id);

        void UpdateJalon(Jalon p_jalon);

        int InsertJalon(Jalon p_jalon);
    }
}
