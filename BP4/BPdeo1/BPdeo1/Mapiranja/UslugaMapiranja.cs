using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPdeo1.Entiteti;
using FluentNHibernate.Mapping;

namespace BPdeo1.Mapiranja
{
    class UslugaMapiranja:ClassMap<Usluga>
    {
        public UslugaMapiranja()
        {
            Table("USLUGA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_USLUGA");

            DiscriminateSubClassesOnColumn("TIP_USLUGE");

            HasManyToMany(x => x.ImaHotele)
             .Table("NUDI")
             .ParentKeyColumn("ID_USLUGE")
             .ChildKeyColumn("ID_HOTELA")
             .Cascade.All();

            HasManyToMany(x => x.Sobe)
             .Table("VEZANA_JE")
             .ParentKeyColumn("ID_USLUGE")
             .ChildKeyColumn("ID_SOBE")
             .Inverse()
             .Cascade.All();
            HasMany(x => x.VezanaJeSoba).KeyColumn("ID_USLUGE").LazyLoad().Cascade.All().Inverse();
        }
    }

    class SpavanjeMapiranja : SubclassMap<Spavanje>
    {
        public SpavanjeMapiranja()
        {
            DiscriminatorValue("ND");
        }
    }
    class PolupansionMapiranja : SubclassMap<Polupansion>
    {
        public PolupansionMapiranja()
        {
            DiscriminatorValue("PP");
        }
    }
    class PansionMapiranja : SubclassMap<Pansion>
    {
        public PansionMapiranja()
        {
            DiscriminatorValue("AI");
        }
    }
}
