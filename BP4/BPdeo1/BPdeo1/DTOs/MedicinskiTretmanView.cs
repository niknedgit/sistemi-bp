using BPdeo1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.DTOs
{
    public class MedicinskiTretmanView
    {
        public int MedicinskiTretmanId { get; set; }
        public string ImeLekara { get; set; }
        public string Specijalnost { get; set; }

        public MedicinskiTretmanView(MedicinskiTretman m)
        {
            this.MedicinskiTretmanId = m.Id;
            this.ImeLekara = m.ImeLekara;
            this.Specijalnost = m.Specijalnost;
        }

        public MedicinskiTretmanView()
        { }
    }
}
