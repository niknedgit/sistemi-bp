using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class Dete
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int Uzrast { get; set; }
        
        public virtual Klijent Roditelj { get; set; }

        public Dete() { }
    }
}
