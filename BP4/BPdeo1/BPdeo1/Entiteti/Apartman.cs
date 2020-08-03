using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public abstract class Apartman
    {
        public virtual int IdSmestaja { get; set; }
        public virtual string ImeVlasnika { get; set; }
        public virtual string PrezimeVlasnika { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string TipApartmana { get; set; }

        public virtual IList<Rezervacija> ImaRezervacije { get; set; }
        public virtual Okruzenje PripadaOkruzenju { get; set; }

        public Apartman()
        {
            ImaRezervacije = new List<Rezervacija>();
        }
    }
    public class Garsonjera : Apartman { }
    public class SaKuhinjom : Apartman { }


}
