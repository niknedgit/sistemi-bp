using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class RezervacijaView
    {
        public int RezervacijaId { get; set; }
        public string TipRezervacije { get; set; }
        public string TipUsluge { get; set; }

        public DateTime Od { get; set; }
        public DateTime Do { get; set; }

        public RezervacijaView(Rezervacija r)
        {
            this.RezervacijaId = r.Id;
            this.TipRezervacije = r.TipRezervacije;
            this.TipUsluge = r.TipUsluge;
            this.Od = r.Od;
            this.Do = r.Do;
        }
        public RezervacijaView()
        { }
    }
}
