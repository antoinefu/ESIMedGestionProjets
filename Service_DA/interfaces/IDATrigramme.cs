using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.interfaces
{
    public interface IDATrigramme
    {
        List<Trigramme> GetAllTrigrammes();

        Trigramme GetTrigrammeById(int p_id);

        int NewTrigramme(Trigramme p_trigramme);

        bool IfTrigrammeExisting(string p_nom);
    }
}
