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
    public class GrupaController : ApiController
    {


        public IEnumerable<GrupaView> Get()
        {
            GrupaProvider provider = new GrupaProvider();

            IEnumerable<GrupaView> grupe = provider.GetGrupe();

            return grupe;
        }

        public GrupaView Get(int id)
        {
            GrupaProvider provider = new GrupaProvider();

            return provider.GetGrupaView(id);
        }

        public int Post([FromBody]Grupa g)
        {
            GrupaProvider provider = new GrupaProvider();

            return provider.AddGrupa(g);
        }

        public int Put([FromBody]Grupa g)
        {
            GrupaProvider provider = new GrupaProvider();

            return provider.EditGrupa(g);
        }

        public int Delete(int id)
        {
            GrupaProvider provider = new GrupaProvider();

            return provider.RemoveGrupa(id);
        }
    }
}
