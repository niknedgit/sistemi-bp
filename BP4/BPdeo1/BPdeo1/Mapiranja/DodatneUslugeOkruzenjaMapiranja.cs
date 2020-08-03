using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class DodatneUslugeOkruzenjaMapiranja : ClassMap<DodatneUslugeOkruzenje>
    {
        public DodatneUslugeOkruzenjaMapiranja()
        {
            Table("DODATNE_USLUGE_OKRUZENJE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_DODATNE_USLUGE_OKRUZENJE");

            Map(x => x.Usluga, "USLUGA");
            References(x => x.PripadaOkruznju).Column("ID_OKRUZENJA");
        }
    }
}
