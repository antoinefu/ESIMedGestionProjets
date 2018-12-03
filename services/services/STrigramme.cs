using bean;
using Service_DA;
using services.interfaces;
using System.Collections.Generic;

namespace services.services
{
    public class STrigramme : ITrigramme
    {
        public List<Trigramme> GetAllTrigrammes()
        {
            return FactoryServiceDA.CreateServiceDATrigramme().GetAllTrigrammes();
        }

        public Trigramme GetTrigrammeById(int p_id)
        {
            return FactoryServiceDA.CreateServiceDATrigramme().GetTrigrammeById(p_id);
        }

        public int NewTrigramme(string p_nom)
        {
            return FactoryServiceDA.CreateServiceDATrigramme().NewTrigramme(new Trigramme(0, p_nom));
        }
    }
}
