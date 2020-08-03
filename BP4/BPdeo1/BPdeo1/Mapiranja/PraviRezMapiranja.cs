using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class PraviRezMapiranja : ClassMap<PraviRez>
    {
        public PraviRezMapiranja()
        {
            Table("PRAVI_REZ");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_PRAVI_REZ");

            Map(x => x.ImeKlijenta, "IME_KLIJENTA");
            Map(x => x.PrezimeKlijenta, "PREZIME_KLIJENTA");
            Map(x => x.JmbgKlijenta, "JMBG_KLIJENTA");
            Map(x => x.DatRodj, "DAT_RODJ");
            Map(x => x.Od, "OD");
            Map(x => x.Do, "DO");
            Map(x => x.TipUsluge, "TIP_USLUGE");

            References(x => x.Rezervacija).Column("ID_REZ");
            References(x => x.Klijent).Column("ID_KLIJENTA");
        }
    }
}
