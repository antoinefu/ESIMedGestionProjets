using bean;
using services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Affichage des types d'éxigences :");
            List<TypeExigence> listTypes = FactoryService.CreateServiceTypeExigence().GetAllTypeExigences();
            foreach (TypeExigence type in listTypes)
            {
                Console.WriteLine("- type exigence :  " + type.Id + " " + type.Label);
            }
            Console.WriteLine("");
            Console.WriteLine("Affichage la liste des trigrammes :");
            List<Trigramme> listTrigramme = FactoryService.CreateServiceTrigramme().GetAllTrigrammes();
            foreach (Trigramme tri in listTrigramme)
            {
                Console.WriteLine("- trigramme :  " + tri.Id + " " + tri.Nom);
            }
            Console.WriteLine("");
            Console.WriteLine("Affichage du trigramme 5 :");
            Trigramme trigramme = FactoryService.CreateServiceTrigramme().GetTrigrammeById(5);
            Console.WriteLine("- trigramme :  " + trigramme.Id + " " + trigramme.Nom);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
