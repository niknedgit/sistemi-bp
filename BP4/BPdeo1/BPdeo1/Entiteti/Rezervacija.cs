using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class Rezervacija
    {
        public virtual int Id { get; set; }
        public virtual string TipRezervacije { get; set; }
        public virtual string TipUsluge { get; set; }

        public virtual DateTime Od { get; set; }
        public virtual DateTime Do { get; set; }

        public virtual Apartman RezApartman { get; set; }

        public Rezervacija() { }
    }

    public class RezervacijaHotela : Rezervacija
    {
        public virtual string TipUsluge { get; set; }

        public virtual Soba RezSoba { get; set; }

        public RezervacijaHotela() { }
    }
}
