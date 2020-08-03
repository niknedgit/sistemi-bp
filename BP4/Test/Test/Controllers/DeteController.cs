using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Http;
using BPdeo1.Entiteti;
using BPdeo1.DTOs;
using BPdeo1.Data_Providers;

namespace Test.Controllers
{
    public class DeteController : ApiController
    {


        public IEnumerable<DeteView> Get()
        {
            DeteProvider provider = new DeteProvider();

            IEnumerable<DeteView> deca = provider.GetDeca();

            return deca;
        }

        public DeteView Get(int id)
        {
            DeteProvider provider = new DeteProvider();

            return provider.GetDeteView(id);
        }

        public int Post([FromBody]Dete d)
        {
            DeteProvider provider = new DeteProvider();

            return provider.AddDete(d);
        }

        public int Put([FromBody]Dete d)
        {
            DeteProvider provider = new DeteProvider();

            return provider.EditDete(d);
        }

        public int Delete(int id)
        {
            DeteProvider provider = new DeteProvider();

            return provider.RemoveDete(id);
        }
    }
}
