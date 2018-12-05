using services.interfaces;
using services.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services
{
    public class FactoryService
    {
        public static ITypeExigence CreateServiceTypeExigence()
        {
            return new STypeExigence();
        }

        public static ITrigramme CreateServiceTrigramme()
        {
            return new STrigramme();
        }

        public static IProjet CreateServiceProjet()
        {
            return new SProjet();
        }

        public static IExigence CreateServiceExigence()
        {
            return new SExigence();
        }
    }
}
