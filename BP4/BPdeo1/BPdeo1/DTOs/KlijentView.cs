
using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class KlijentView
    {
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public DateTime Dat_rodj { get; set; }
        public string Prezime { get; set; }
        public string Jmbg { get; set; }

        //public string PripadaGrupi { get; set; }

        public KlijentView(Klijent k)
        {
            this.KlijentId = k.Id;
            this.Ime = k.Ime;
            this.Prezime = k.Prezime;
            this.Dat_rodj = k.Dat_rodj;
            this.Jmbg = k.Jmbg;
            //this.PripadaGrupi = k.PripadaGrupi.Naziv;
        }

        public KlijentView()
        {

        }
    }
}
