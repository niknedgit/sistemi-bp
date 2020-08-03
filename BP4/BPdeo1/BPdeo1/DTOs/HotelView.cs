using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class HotelView
    {

        public int IdSmestaja { get; set; }
        public string Sifra { get; set; }
        public string Ime { get; set; }
        public int Br_lezaja { get; set; }
        public string Adresa { get; set; }
        public string Kategorija { get; set; }
        public string Grad { get; set; }
        public int Restoran_mesta { get; set; }
        public string Direktor { get; set; }
        //public string PripadaOkruzenju { get; set; }

        public HotelView(Hotel h)
        {
            this.IdSmestaja = h.IdSmestaja;
            this.Grad = h.Grad;
            this.Ime = h.Ime;
            this.Restoran_mesta = h.Restoran_mesta;
            this.Br_lezaja = h.Br_lezaja;
            this.Adresa = h.Adresa;
            this.Sifra = h.Sifra;
            this.Kategorija = h.Kategorija;
            this.Direktor = h.Direktor;
            //this.PripadaOkruzenju = h.PripadaOkruzenju.TipOkruzenja;
        }

        public HotelView()
        { }
    }
}
