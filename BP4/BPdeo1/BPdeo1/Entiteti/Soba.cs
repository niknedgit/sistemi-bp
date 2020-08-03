using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class Soba
    {
        public virtual int Id { get; set; }
        public virtual int Broj { get; set; }
        public virtual int Sprat { get; set; }
        public virtual string Radio { get; set; }
        public virtual string Tv { get; set; }
        public virtual string Kupatilo { get; set; }
        public virtual string Klima { get; set; }
        public virtual string Slobodno { get; set; }
        public virtual string More { get; set; }
        public virtual string Frizider { get; set; }
        public virtual int Tip { get; set; }  //??

        public virtual Hotel PripadaHotelu { get; set; }

        public virtual IList<Usluga> Usluge { get; set; }
        public virtual IList<VezanaJe> VezanaJeUsluga { get; set; }
        public virtual IList<RezervacijaHotela> RezervacijeHotela { get; set; }

        public Soba()
        {
            Usluge = new List<Usluga>();
            VezanaJeUsluga = new List<VezanaJe>();
        }
    }

    public class Jednokrevetna : Soba { }
    public class Dvokrevetna : Soba { }
    public class Trokrevetna : Soba { }
}
