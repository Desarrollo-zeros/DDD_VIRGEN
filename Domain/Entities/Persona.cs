using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona : Entity<int>
    {
        public string Documento { set; get; }
        public string PrimerNombre { set; get; }
        public string SegundoNombre { set; get; }
        public string PrimerApellido { set; get; }
        public string SegundoApellido { set; get; }
        public int Edad { set; get; }

        public virtual IEnumerable<Dirección> Direccións { set; get; }
    }
}
