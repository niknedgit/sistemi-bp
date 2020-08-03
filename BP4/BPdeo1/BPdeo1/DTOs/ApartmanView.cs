using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
   public class ApartmanView
    {
        public int IdSmestaja { get; set; }
        public string ImeVlasnika { get; set; }
        public string PrezimeVlasnika { get; set; }
        public string Telefon { get; set; }
        public string TipApartmana { get; set; }

        //public string PripadaOkruzenju { get; set; }

        public ApartmanView(Apartman a)
        {
            this.IdSmestaja = a.IdSmestaja;
            this.ImeVlasnika = a.ImeVlasnika;
            this.PrezimeVlasnika = a.PrezimeVlasnika;
            this.Telefon = a.Telefon;
            this.TipApartmana = a.TipApartmana;
            //this.PripadaOkruzenju = a.PripadaOkruzenju.TipOkruzenja;
        }

        public ApartmanView()
        { }
    }
}
