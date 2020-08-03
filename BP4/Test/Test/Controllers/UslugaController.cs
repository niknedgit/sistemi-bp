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
    public class UslugaController : ApiController
    {


        public IEnumerable<UslugaView> Get()
        {
            UslugaProvider provider = new UslugaProvider();

            IEnumerable<UslugaView> usluge = provider.GetUsluge();

            return usluge;
        }

        public UslugaView Get(int id)
        {
            UslugaProvider provider = new UslugaProvider();

            return provider.GetUslugaView(id);
        }

        public int Post([FromBody]Usluga u)
        {
            UslugaProvider provider = new UslugaProvider();

            return provider.AddUsluga(u);
        }

        public int Put([FromBody]Usluga u)
        {
            UslugaProvider provider = new UslugaProvider();

            return provider.EditUsluga(u);
        }

        public int Delete(int id)
        {
            UslugaProvider provider = new UslugaProvider();

            return provider.RemoveUsluga(id);
        }
    }
}
