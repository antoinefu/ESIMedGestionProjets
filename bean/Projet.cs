using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class Projet
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Trigramme { get; set; }
        public int Responsable { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFinPrevue { get; set; }

        public Projet(int p_id, string p_nom, string p_trigramme, int p_responsable, DateTime p_dateDebut, DateTime p_dateFinPrevue)
        {
            this.Id = p_id;
            this.Nom = p_nom;
            this.Trigramme = p_trigramme;
            this.Responsable = p_responsable;
            this.DateDebut = p_dateDebut;
            this.DateFinPrevue = p_dateFinPrevue;
        }
    }
}
