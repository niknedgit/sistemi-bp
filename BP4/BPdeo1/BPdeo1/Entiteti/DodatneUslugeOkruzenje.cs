using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class DodatneUslugeOkruzenje
    {
        public virtual int Id { get; set; }
        public virtual string Usluga { get; set; }
        public virtual Okruzenje PripadaOkruznju { get; set; }

        public DodatneUslugeOkruzenje() { }
    }
}
