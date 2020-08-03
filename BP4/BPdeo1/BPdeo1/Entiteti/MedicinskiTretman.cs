using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class MedicinskiTretman
    {
        public virtual int Id { get; set; }
        public virtual string ImeLekara { get; set; }
        public virtual string Specijalnost { get; set; }

        public virtual IList<Okruzenje> OkruzenjeTretman { get; set; }

        public MedicinskiTretman()
        {
            OkruzenjeTretman = new List<Okruzenje>();
        }
    }
}
