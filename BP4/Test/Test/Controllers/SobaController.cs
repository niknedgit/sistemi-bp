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
    public class SobaController : ApiController
    {


        public IEnumerable<SobaView> Get()
        {
            SobaProvider provider = new SobaProvider();

            IEnumerable<SobaView> sobe = provider.GetSobe();

            return sobe;
        }

        public SobaView Get(int id)
        {
            SobaProvider provider = new SobaProvider();

            return provider.GetSobaView(id);
        }

        public int Post([FromBody]Soba s)
        {
            SobaProvider provider = new SobaProvider();

            return provider.AddSoba(s);
        }

        public int Put([FromBody]Soba s)
        {
            SobaProvider provider = new SobaProvider();

            return provider.EditSoba(s);
        }

        public int Delete(int id)
        {
            SobaProvider provider = new SobaProvider();

            return provider.RemoveSoba(id);
        }
    }
}
