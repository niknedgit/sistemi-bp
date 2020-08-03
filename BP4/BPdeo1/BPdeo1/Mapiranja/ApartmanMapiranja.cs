using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class ApartmanMapiranja : ClassMap<Apartman>
    {
        public ApartmanMapiranja()
        {
            Table("APARTMAN");

            Id(x => x.IdSmestaja, "ID_SMESTAJA").GeneratedBy.TriggerIdentity();//SequenceIdentity("S16116.S_SMESTAJ");


            DiscriminateSubClassesOnColumn("TIP_APARTMANA");

            Map(x => x.ImeVlasnika).Column("IME_VLASNIKA");
            Map(x => x.PrezimeVlasnika).Column("PREZIME_VLASNIKA");
            Map(x => x.Telefon).Column("TELEFON");

            References(x => x.PripadaOkruzenju).Column("ID_OKRUZENJA");

            HasMany(x => x.ImaRezervacije).KeyColumn("ID_APARTMANA").LazyLoad().Cascade.All().Inverse();
        }
    }

    class GarsonjeraMapiranja : SubclassMap<Garsonjera>
    {
        public GarsonjeraMapiranja()
        {
            DiscriminatorValue("Garsonjera");
        }
    }
    class SaKuhinjomMapiranja : SubclassMap<SaKuhinjom>
    {
        public SaKuhinjomMapiranja()
        {
            DiscriminatorValue("Sa kuhinjom");
        }
    }
}
