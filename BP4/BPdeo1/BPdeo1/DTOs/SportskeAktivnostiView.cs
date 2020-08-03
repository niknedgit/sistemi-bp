using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class SportskeAktivnostiView
    {
        public int AktivnostId { get; set; }
        public string Aktivnost { get; set; }
        //public string PripadaHotelu { get; set; }

        public SportskeAktivnostiView(SportskeAktivnosti sa)
        {
            this.AktivnostId = sa.Id;
            this.Aktivnost = sa.Aktivnost;
            //this.PripadaHotelu = sa.PripadaHotelu.Ime;
        }

        public SportskeAktivnostiView()
        { }
    }
}
