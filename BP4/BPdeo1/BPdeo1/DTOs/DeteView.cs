using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
   public class DeteView
    {
        public int DeteId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Uzrast { get; set; }

        public string ImeRoditelja { get; set; }


        public DeteView(Dete d)
        {
            this.DeteId = d.Id;
            this.Ime = d.Ime;
            this.ImeRoditelja = d.Roditelj.Ime;
            this.Prezime = d.Prezime;
            this.Uzrast = d.Uzrast;
        }

        public DeteView()
        {

        }
    }

}