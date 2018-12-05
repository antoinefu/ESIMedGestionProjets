using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class Exigence
    {
        public int Id { get; set; }
        public string Decription { get; set; }
        public bool Fonctionnelle { get; set; }
        public int Type { get; set; }
        public int Projet { get; set; }

        public Exigence(int p_id, string p_description, bool p_fonctionnelle, int p_type, int p_projet)
        {
            this.Id = p_id;
            this.Decription = p_description;
            this.Fonctionnelle = p_fonctionnelle;
            this.Type = p_type;
            this.Projet = p_projet;
        }
    }
}
