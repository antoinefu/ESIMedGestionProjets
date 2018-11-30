using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bean
{
    public class TypeExigence
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public TypeExigence(int p_id, string p_label)
        {
            this.Id = p_id;
            this.Label = p_label;
        }
    }
}
