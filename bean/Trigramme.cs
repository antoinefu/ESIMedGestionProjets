using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class Trigramme
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Trigramme(int p_id, string p_nom)
        {
            this.Id = p_id;
            this.Nom = p_nom;
        }
    }
}
