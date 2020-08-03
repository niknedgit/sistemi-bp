using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public abstract class Okruzenje
    {
        public virtual int Id { get; set; }
        public virtual String TipOkruzenja { get; set; }

        public virtual IList<Apartman> Apartmani { get; set; }
        public virtual IList<Hotel> Hoteli { get; set; }

        public virtual IList<MedicinskiTretman> MedicinskiTretmani { get; set; }

        public Okruzenje()
        {
            Apartmani = new List<Apartman>();
            Hoteli = new List<Hotel>();
            MedicinskiTretmani = new List<MedicinskiTretman>();
        }
    }

    public class Banja : Okruzenje
    {

    }
    public class Spa : Okruzenje
    {

    }
    public class BanjaSaSpa : Okruzenje
    {

    }
}
