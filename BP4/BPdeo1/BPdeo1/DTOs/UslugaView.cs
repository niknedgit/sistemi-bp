using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class UslugaView
    {
        public int UslugaId { get; set; }
        public string TipUsluge { get; set; }

        public UslugaView(Usluga u)
        {
            this.UslugaId = u.Id;
            this.TipUsluge = u.TipUsluge;
        }

        public UslugaView()
        { }
    }
}
