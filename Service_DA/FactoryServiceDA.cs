using Service_DA.interfaces;
using Service_DA.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DA
{
    public class FactoryServiceDA
    {
        public static IDATypeExigence CreateServicDATypeExigence()
        {
            return new SDATypeExigence();
        }

        public static IDATrigramme CreateServiceDATrigramme()
        {
            return new SDATrigramme();
        }

        public static IDAProjet CreateServiceDAProjet()
        {
            return new SDAProjet();
        }

        public static IDAExigence CreateServiceDAExigence()
        {
            return new SDAExigence();
        }

        public static IDATache CreateServiceDATache()
        {
            return new SDATache();
        }
        public static IDAJalon CreateServiceDAJalon()
        {
            return new SDAJalon();
        }
    }
}
