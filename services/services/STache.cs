using bean;
using Service_DA;
using services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.services
{
    public class STache : ITache
    {
        public List<Tache> GetTachesByJalon(int p_idJalon)
        {
            return FactoryServiceDA.CreateServiceDATache().GetTachesByIdJalon(p_idJalon);
        }
    }
}
