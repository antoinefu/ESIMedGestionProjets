using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class Jalon
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Responsable { get; set; }
        public DateTime DateLivraisonPrevue { get; set; }
        public DateTime DateLivraisonReelle { get; set; }
        public int Projet { get; set; }

        public Jalon(int p_id, string p_nom, int p_responsable, DateTime p_dateLivraisonPrevue, DateTime p_dateLivraisonReelle, int p_projet)
        {
            this.Id = p_id;
            this.Nom = p_nom;
            this.Responsable = p_responsable;
            this.DateLivraisonPrevue = p_dateLivraisonPrevue;
            this.DateLivraisonReelle = p_dateLivraisonReelle;
            this.Projet = p_projet;
        }
    }
}
