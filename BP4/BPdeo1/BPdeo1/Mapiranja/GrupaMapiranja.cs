using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using BPdeo1.Entiteti;
namespace BPdeo1.Mapiranja
{
    class GrupaMapiranja : ClassMap<Grupa>
    {
        public GrupaMapiranja()
        {
            Table("GRUPA");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("S16116.S_GRUPA");
            //Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            HasMany(x => x.Klijenti).KeyColumn("ID_GRUPE").Cascade.All().Inverse(); 
                                                            //.cascade => ako snimimo gpupu 
                                                            //snimaju se i klijenti i slicno 

                                                            //.inverse =>  naglasavamo da postoji 
                                                            //veza i u suprotnom smeru
        }       
    }
}
