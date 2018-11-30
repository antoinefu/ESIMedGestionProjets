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
    public class STypeExigence : ITypeExigence
    {
        public List<TypeExigence> GetAllTypeExigences()
        {
            return FactoryServiceDA.CreateServicDATypeExigence().GetAllTypeExigences();
        }
    }
}
