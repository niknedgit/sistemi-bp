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
    public class ApartmanController : ApiController
    {
        // GET api/apartman
        public IEnumerable<ApartmanView> Get()
        {
            ApartmanProvider provider = new ApartmanProvider();

            IEnumerable<ApartmanView> apartmani = provider.GetApartmani();

            return apartmani;
        }

        public ApartmanView Get(int id)
        {
            ApartmanProvider provider = new ApartmanProvider();

            return provider.GetApartmanView(id);
        }

        public int Post([FromBody]Apartman a)
        {
            ApartmanProvider provider = new ApartmanProvider();

            return provider.AddApartman(a);
        }

        public int Put([FromBody]Apartman a)
        {
            ApartmanProvider provider = new ApartmanProvider();

            return provider.EditApartman(a);
        }

        public int Delete(int id)
        {
            ApartmanProvider provider = new ApartmanProvider();

            return provider.RemoveApartman(id);
        }
    }
}
