using System;
using bean;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface ITrigramme
    {
        List<Trigramme> GetAllTrigrammes();

        Trigramme GetTrigrammeById(int p_id);

        int NewTrigramme(string p_nom);
    }
}
