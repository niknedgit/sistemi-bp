using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prodavnica.DTOs
{
    public class VojnikView
    {
        public string NazivSerije { get; set; }
        public string Baterije { get; set; }
        public string Metal { get; set; }
        public string Plastika { get; set; }
        public  IList<OdeljenjeView> Odeljenja { get; set; }

        public VojnikView(Vojnik v)
        {
            this.Odeljenja = new List<OdeljenjeView>();
            this.NazivSerije = v.NazivSerije;
            this.Baterije = v.Baterije;
            this.Metal = v.Metal;
            this.Plastika = v.Plastika;

            foreach(ProdajeSe odProdajeSe in v.ProdajeSeOdeljenja)
            {
                this.Odeljenja.Add(new OdeljenjeView(odProdajeSe.ProdajeOdeljenje));
            }
        }

        public VojnikView()
        {

        }
    }
}
