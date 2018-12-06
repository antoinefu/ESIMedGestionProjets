using bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface ITache
    {
        List<Tache> GetTachesByJalon(int p_idJalon);
    }
}
