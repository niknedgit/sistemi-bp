using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.DTOs
{
    public class OdeljenjeView
    {
        public int OdeljenjeId { get; set; }
        public string Lokacija { get; set; }
        public string NazivProdavnice { get; set; }
        public int BrojProizvoda { get; set; }

        public OdeljenjeView(Odeljenje o)
        {
            this.OdeljenjeId = o.Id;
            this.Lokacija = o.Lokacija;
            this.NazivProdavnice = o.PripadaProdavnici.Naziv;
            this.BrojProizvoda = o.ProdajeSeProizvod.Count;
        }

        public OdeljenjeView()
        {

        }
    }
}
