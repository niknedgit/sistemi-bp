using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class Grupa
    {
        public virtual int Id { get; set; }
        public virtual string Naziv{ get; set; }
    
        public virtual IList<Klijent> Klijenti { get; set; }

        public Grupa()
        {
            Klijenti = new List<Klijent>();
        }
    }
}
