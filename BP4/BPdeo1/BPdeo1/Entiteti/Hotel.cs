using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
   public class Hotel
    {
        public virtual int IdSmestaja { get; set; }
        public virtual string Sifra { get; set; }
        public virtual string Ime { get; set; }
        public virtual int Br_lezaja  { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Kategorija { get; set; }
        public virtual string Grad  { get; set; }
        public virtual int Restoran_mesta  { get; set; }
        public virtual string Direktor { get; set; }

        public virtual IList<Soba> ImaSobe { get; set; }

        public virtual IList<Usluga> ImaUsluge { get; set; }

        public virtual Okruzenje PripadaOkruzenju { get; set; }

        public Hotel()
        {
            ImaSobe = new List<Soba>();

            ImaUsluge = new List<Usluga>();
        }
    }
}
