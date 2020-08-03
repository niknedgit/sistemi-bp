using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class Klijent
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual DateTime Dat_rodj { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Jmbg { get; set; }

        public virtual Grupa PripadaGrupi { get; set; }
        public virtual IList<Dete> Deca { get; set; }
        public Klijent()
        {
            Deca = new List<Dete>();
        }

    }
}
