using System;
using bean;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA.interfaces
{
    public interface IDATache
    {
        List<Tache> GetTachesByIdJalon(int p_idJalon);
    }
}
