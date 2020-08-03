using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using BPdeo1.Entiteti;
using BPdeo1.DTOs;
using BPdeo1.Data_Providers;

namespace Test.Controllers
{
    public class RezervacijaController : ApiController
    {


        public IEnumerable<RezervacijaView> Get()
        {
            RezervacijaProvider provider = new RezervacijaProvider();

            IEnumerable<RezervacijaView> rez = provider.GetRezervacije();

            return rez;
        }

        public RezervacijaView Get(int id)
        {
            RezervacijaProvider provider = new RezervacijaProvider();

            return provider.GetRezervacijaView(id);
        }

        public int Post([FromBody]Rezervacija r)
        {
            RezervacijaProvider provider = new RezervacijaProvider();

            return provider.AddRezervacija(r);
        }

        public int Put([FromBody]Rezervacija r)
        {
            RezervacijaProvider provider = new RezervacijaProvider();

            return provider.EditRezervacija(r);
        }

        public int Delete(int id)
        {
            RezervacijaProvider provider = new RezervacijaProvider();

            return provider.RemoveRezervacija(id);
        }
    }
}
