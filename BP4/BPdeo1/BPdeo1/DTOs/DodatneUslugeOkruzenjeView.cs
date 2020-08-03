using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class DodatneUslugeOkruzenjeView
    {
        public int DodatnaUslugaId { get; set; }
        public string Usluga { get; set; }
        public String PripadaOkruznju { get; set; }

        public DodatneUslugeOkruzenjeView(DodatneUslugeOkruzenje d)
        {
            this.DodatnaUslugaId = d.Id;
            this.Usluga = d.Usluga;
            this.PripadaOkruznju = d.PripadaOkruznju.TipOkruzenja;
        }

        public DodatneUslugeOkruzenjeView()
        { }
    }
}
