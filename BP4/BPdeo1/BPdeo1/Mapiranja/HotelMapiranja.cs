using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;

namespace BPdeo1.Mapiranja
{
    class HotelMapiranja : ClassMap<Hotel>
    {
        public HotelMapiranja()
        {
            Table("HOTEL");

            Id(x => x.IdSmestaja, "ID_SMESTAJA").GeneratedBy.SequenceIdentity("S16116.S_SMESTAJ");

            Map(x => x.Sifra, "SIFRA");
            Map(x => x.Ime, "IME");
            Map(x => x.Br_lezaja, "BR_LEZAJA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Kategorija, "KATEGORIJA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Restoran_mesta, "RESTORAN_MESTA");
            Map(x => x.Direktor, "DIREKTOR");

            References(x => x.PripadaOkruzenju).Column("ID_OKRUZENJA");

            HasMany(x => x.ImaSobe).KeyColumn("ID").Cascade.All().Inverse();

            HasManyToMany(x => x.ImaUsluge)
             .Table("NUDI")
             .ParentKeyColumn("ID_HOTELA")
             .ChildKeyColumn("ID_USLUGE")
             .Cascade.All();
        }
    }
}
