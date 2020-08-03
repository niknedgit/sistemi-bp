using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;
namespace BPdeo1.Mapiranja
{
    class SportskeAktivnostiMapiranja:ClassMap<SportskeAktivnosti>
    {
        public SportskeAktivnostiMapiranja()
        {
            Table("SPORTSKE_AKTIVNOSTI");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_SPORT");

            Map(x => x.Aktivnost, "AKTIVNOST");

            References(x => x.PripadaHotelu).Column("ID_HOTELA");
        }
    }
}
