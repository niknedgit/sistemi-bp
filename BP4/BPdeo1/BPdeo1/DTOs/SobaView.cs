using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public  class SobaView
    {
        public int SobaId { get; set; }
        public int Broj { get; set; }
        public int Sprat { get; set; }
        public string Radio { get; set; }
        public string Tv { get; set; }
        public string Kupatilo { get; set; }
        public string Klima { get; set; }
        public string Slobodno { get; set; }
        public string More { get; set; }
        public string Frizider { get; set; }
        public int Tip { get; set; }  //??

        //public string PripadaHotelu { get; set; }

        public SobaView(Soba s)
        {
            this.SobaId = s.Id;
            this.Broj = s.Broj;
            this.Sprat = s.Sprat;
            this.Radio = s.Radio;
            this.Tv = s.Tv;
            this.Kupatilo = s.Kupatilo;
            this.Klima = s.Klima;
            this.Slobodno = s.Slobodno;
            this.More = s.More;
            this.Frizider = s.Frizider;
            this.Tip = s.Tip;
            //this.PripadaHotelu = s.PripadaHotelu.Ime;
        }

        public SobaView()
        { }
    }
}
