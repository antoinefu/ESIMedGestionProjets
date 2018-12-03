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
            Console.WriteLine("Affichage du trigramme 14 :");
            Trigramme trigramme = FactoryService.CreateServiceTrigramme().GetTrigrammeById(4);
            Console.WriteLine("- trigramme :  " + trigramme.Id + " " + trigramme.Nom);
            Console.WriteLine("");
            Console.WriteLine("Affichage des projets :");
            //int result = FactoryService.CreateServiceProjet().NewProjet("Gestion de projets 2", "GDP", 2, DateTime.Now, DateTime.Now);
            //FactoryService.CreateServiceProjet().DeleteProjet(1);
            //int result = FactoryService.CreateServiceProjet().UpdateProjet("Gestion de projets 66", "GDP", 5, DateTime.Now, DateTime.Now, 2);
            List<Projet> listProjets = FactoryService.CreateServiceProjet().GetAllProjets();
            foreach (Projet projet in listProjets)
            {
                Console.WriteLine("- "+projet.Id+" "+projet.Nom+" "+projet.Trigramme+" "+projet.Responsable+" "+projet.DateDebut+" "+projet.DateFinPrevue);
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
