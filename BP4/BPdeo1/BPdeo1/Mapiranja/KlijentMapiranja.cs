using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;
namespace BPdeo1.Mapiranja
{
    class KlijentMapiranja : ClassMap<Klijent>
    {
        public KlijentMapiranja()
        {
            Table("KLIJENT");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();//SequenceIdentity("S16116.S_KLIJENT");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Dat_rodj, "DAT_RODJ");
            Map(x => x.Jmbg, "JMBG");

            References(x => x.PripadaGrupi).Column("ID_GRUPE");
            HasMany(x => x.Deca).KeyColumn("ID_RODITELJA").Inverse().Cascade.All();
        }    
    }
}
