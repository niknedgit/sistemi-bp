using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class VezanaJeMapiranja : ClassMap<VezanaJe>
    {
        public VezanaJeMapiranja()
        {
            Table("VEZANA_JE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_VEZANA_JE");
            Map(x => x.Cena, "CENA");

            References(x => x.Soba).Column("ID_SOBE"); 
            References(x => x.Usluga).Column("ID_USLUGE"); 
        }
    }
}
