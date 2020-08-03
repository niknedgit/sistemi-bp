using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class OkruzenjeMapiranja :ClassMap<Okruzenje>
    {
        public OkruzenjeMapiranja()
        {
            Table("OKRUZENJE");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_OKRUZENJE");
            DiscriminateSubClassesOnColumn("TIP_OKRUZENJA");

            HasMany(x => x.Hoteli).KeyColumn("ID_OKRUZENJA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Apartmani).KeyColumn("ID_OKRUZENJA").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.MedicinskiTretmani)
           .Table("NUDI_TRETMAN")
           .ParentKeyColumn("ID_OKRUZENJA")
           .ChildKeyColumn("ID_TRETMANA")
           .Cascade.All();
        }
    }

    class BanjaMapiranja : SubclassMap<Banja>
    {
        public BanjaMapiranja()
        {
            DiscriminatorValue("Banja");
        }
    }
    class SpaMapiranja : SubclassMap<Spa>
    {
        public SpaMapiranja()
        {
            DiscriminatorValue("Spa");
        }
    }
    class BanjaSaSpaMapiranja : SubclassMap<BanjaSaSpa>
    {
        public BanjaSaSpaMapiranja()
        {
            DiscriminatorValue("Banja sa spa centrom");
        }
    }
}
