using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class SportskeAktivnosti
    {
        public virtual int Id { get; set; }
        public virtual string Aktivnost { get; set; }
        public virtual Hotel PripadaHotelu { get; set; }

        public SportskeAktivnosti() { }
    }
}
