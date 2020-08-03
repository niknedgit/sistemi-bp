using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class GrupaView
    {
        public int GrupaId { get; set; }
        public string Naziv { get; set; }

        public GrupaView(Grupa g)
        {
            this.GrupaId = g.Id;
            this.Naziv = g.Naziv;
        }

        public GrupaView()
        {

        }
    }
}
