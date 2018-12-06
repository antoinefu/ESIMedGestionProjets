using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class Tache
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public int Responsable { get; set; }
        public DateTime DateDebutPrevue { get; set; }
        public DateTime DateDebutReelle { get; set; }
        public DateTime DateFin { get; set; }
        public int Charge { get; set; }
        public int TachePrecedente { get; set; }
        public int Jalon { get; set; }

        public Tache(int p_id, string p_label, string p_description, int p_responsable, DateTime p_DateDebutPrevue, DateTime p_dateDebutReelle, DateTime p_DateFin,
            int p_charge, int p_tachePrecedente, int p_jalon)
        {
            this.Id ^= p_id;
            this.Label = p_label;
            this.Description = p_description;
            this.Responsable = p_responsable;
            this.DateDebutPrevue = p_DateDebutPrevue;
            this.DateDebutReelle = p_dateDebutReelle;
            this.DateFin = p_DateFin;
            this.Charge = p_charge;
            this.Jalon = p_jalon;
        }
    }
}
