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
    public class OkruzenjeController : ApiController
    {


        public IEnumerable<OkruzenjeView> Get()
        {
            OkruzenjeProvider provider = new OkruzenjeProvider();

            IEnumerable<OkruzenjeView> okruzenja = provider.GetOkruzenja();

            return okruzenja;
        }

        public OkruzenjeView Get(int id)
        {
            OkruzenjeProvider provider = new OkruzenjeProvider();

            return provider.GetOkruzenjeView(id);
        }

        public int Post([FromBody]Okruzenje o)
        {
            OkruzenjeProvider provider = new OkruzenjeProvider();

            return provider.AddOkruzenje(o);
        }

        public int Put([FromBody]Okruzenje o)
        {
            OkruzenjeProvider provider = new OkruzenjeProvider();

            return provider.EditOkruzenje(o);
        }

        public int Delete(int id)
        {
            OkruzenjeProvider provider = new OkruzenjeProvider();

            return provider.RemoveOkruzenje(id);
        }
    }
}
