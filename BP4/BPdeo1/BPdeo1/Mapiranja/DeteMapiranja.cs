using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPdeo1.Entiteti;
using FluentNHibernate.Mapping;

namespace BPdeo1.Mapiranja
{
    class DeteMapiranja: ClassMap<Dete>
    {
        public DeteMapiranja()
        {
            Table("DETE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_DETE");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Uzrast, "UZRAST");

            References(x => x.Roditelj).Column("ID_RODITELJA");//inverse
        }
    }
}
