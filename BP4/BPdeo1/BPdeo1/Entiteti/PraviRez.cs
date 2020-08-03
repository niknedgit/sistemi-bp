using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class PraviRez
    {
        public virtual int Id { get; set; }
        
        public virtual String ImeKlijenta { get; set; }
        public virtual String PrezimeKlijenta { get; set; }
        public virtual String JmbgKlijenta { get; set; }
        public virtual DateTime DatRodj { get; set; }

        public virtual DateTime Od { get; set; }
        public virtual DateTime Do { get; set; }

        public virtual String TipUsluge { get; set; }

        public virtual Rezervacija Rezervacija { get; set; }
        public virtual Klijent Klijent { get; set; }

        public PraviRez() { }
    }
}
