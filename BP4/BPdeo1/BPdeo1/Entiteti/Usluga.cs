using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public abstract class Usluga
    {
        public virtual int Id { get; set; }
        public virtual String TipUsluge { get; set; }

        public virtual IList<Hotel> ImaHotele { get; set; }

        public virtual IList<Soba> Sobe{ get; set; }
        public virtual IList<VezanaJe> VezanaJeSoba { get; set; }

        public Usluga()
        {
            ImaHotele = new List<Hotel>();

            VezanaJeSoba = new List<VezanaJe>();

            Sobe = new List<Soba>();
        }
    }

    public class Spavanje : Usluga { }
    public class Polupansion : Usluga { }
    public class Pansion : Usluga { }
}
