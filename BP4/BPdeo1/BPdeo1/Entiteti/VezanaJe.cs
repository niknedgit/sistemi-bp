using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Entiteti
{
    public class VezanaJe
    {
        public virtual int Id { get; set; }
        public virtual int Cena { get; set; }

        public virtual Soba Soba { get; set; } //?!
        public virtual Usluga Usluga { get; set; }  //?!
    }
    //slozeniji slucaj jer ima dodatni atribut pa mora novi entitet(medjutabela) 
    //i plus nova klasa za kompozitni kljuc
    //ako imamo samo 2 kompozitna kljuca onda ne mora surogat jer ce has many to many da resi to
    //ako imamo i dodatne kolone onda bolje surogat da ne bismo imali dodatnu klasu za ID
}
