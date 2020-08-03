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
    public class KlijentController : ApiController
    {


        public IEnumerable<KlijentView> Get()
        {
            KlijentProvider provider = new KlijentProvider();

            IEnumerable<KlijentView> klijenti = provider.GetKlijenti();



            return klijenti;
        }

        public KlijentView Get(int id)
        {
            KlijentProvider provider = new KlijentProvider();

            return provider.GetKlijentView(id);
        }

        public int Post([FromBody]Klijent k)
        {
            KlijentProvider provider = new KlijentProvider();

            return provider.AddKlijent(k);
        }

        public int Put([FromBody]Klijent k)
        {
            KlijentProvider provider = new KlijentProvider();

            return provider.EditKlijent(k);
        }

        public int Delete(int id)
        {
            KlijentProvider provider = new KlijentProvider();

            return provider.RemoveKlijent(id);
        }
    }
}
