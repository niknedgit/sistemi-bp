using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class OkruzenjeView
    {
        public int OkruzenjeId { get; set; }
        public String TipOkruzenja { get; set; }

        public OkruzenjeView(Okruzenje o)
        {
            this.OkruzenjeId = o.Id;
            this.TipOkruzenja = o.TipOkruzenja;
        }
        public OkruzenjeView()
        { }
    }
}
