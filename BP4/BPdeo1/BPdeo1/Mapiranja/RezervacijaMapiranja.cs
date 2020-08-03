using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class RezervacijaMapiranja:ClassMap<Rezervacija>
    {
        public RezervacijaMapiranja()
        {
            Table("REZERVACIJA");

            DiscriminateSubClassesOnColumn("TIP_REZERVACIJE", "APARTMAN");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_REZERVACIJA");
            
            Map(x => x.Od, "OD");
            Map(x => x.Do, "DO");

            References(x => x.RezApartman).Column("ID_APARTMANA");
        }
    }

    class RezervacijaHotelaMapiranja : SubclassMap<RezervacijaHotela>
    {
        public RezervacijaHotelaMapiranja()
        {
            DiscriminatorValue("HOTEL");

            Map(x => x.TipUsluge, "TIP_USLUGE");

            References(x => x.RezSoba).Column("ID_SOBE");
        }
    }
}
