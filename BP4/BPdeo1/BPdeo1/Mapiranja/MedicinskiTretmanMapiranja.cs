using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPdeo1.Entiteti;
using FluentNHibernate.Mapping;
namespace BPdeo1.Mapiranja
{
    class MedicinskiTretmanMapiranja: ClassMap<MedicinskiTretman>
    {

        public MedicinskiTretmanMapiranja()
        {
            Table("MEDICINSKI_TRETMAN");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_TRETMAN");

            Map(x => x.ImeLekara, "IME_LEKARA");
            Map(x => x.Specijalnost, "SPECIJALNOST");

            HasManyToMany(x => x.OkruzenjeTretman)
              .Table("NUDI_TRETMAN")
              .ParentKeyColumn("ID_TRETMANA")
              .ChildKeyColumn("ID_OKRUZENJA")
              .Inverse()
              .Cascade.All();
        }
    }
}
