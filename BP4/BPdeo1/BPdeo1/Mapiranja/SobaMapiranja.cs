using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;
namespace BPdeo1.Mapiranja
{
    class SobaMapiranja : ClassMap<Soba>
    {
        public SobaMapiranja()
        {
            Table("SOBA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_SOBA");

            DiscriminateSubClassesOnColumn("TIP");

            Map(x => x.Broj, "BROJ");
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Radio, "RADIO");
            Map(x => x.Tv, "TV");
            Map(x => x.Kupatilo, "KUPATILO");
            Map(x => x.Klima, "KLIMA");
            Map(x => x.Slobodno, "SLOBODNO");
            Map(x => x.More, "MORE");
            Map(x => x.Frizider, "FRIZIDER");

            References(x => x.PripadaHotelu).Column("ID_HOTELA");

            HasManyToMany(x => x.Usluge)
             .Table("VEZANA_JE")
             .ParentKeyColumn("ID_SOBE")
             .ChildKeyColumn("ID_USLUGE")
             .Cascade.All();
            HasMany(x => x.VezanaJeUsluga).KeyColumn("ID_SOBE").LazyLoad();

            HasMany(x => x.RezervacijeHotela).KeyColumn("ID_SOBE").LazyLoad().Cascade.All().Inverse();
        }
    }

    class JednokrevetnaMapiranja:SubclassMap<Jednokrevetna>
    {
        public JednokrevetnaMapiranja()
        {
            DiscriminatorValue(1);
        }
    }
    class DvokrevetnaMapiranja : SubclassMap<Dvokrevetna>
    {
        public DvokrevetnaMapiranja()
        {
            DiscriminatorValue(2);
        }
    }
    class TrokrevetnaMapiranja : SubclassMap<Trokrevetna>
    {
        public TrokrevetnaMapiranja()
        {
            DiscriminatorValue(3);
        }
    }
}
