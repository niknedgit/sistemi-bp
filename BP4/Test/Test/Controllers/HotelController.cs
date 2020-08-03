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
    public class HotelController : ApiController
    {


        public IEnumerable<HotelView> Get()
        {
            HotelProvider provider = new HotelProvider();

            IEnumerable<HotelView> hoteli = provider.GetHoteli();



            return hoteli;
        }

        public HotelView Get(int id)
        {
            HotelProvider provider = new HotelProvider();

            return provider.GetHotel(id);
        }

        public int Post([FromBody]Hotel h)
        {
            HotelProvider provider = new HotelProvider();

            return provider.AddHotel(h);
        }

        public void Put(int id, [FromBody]Hotel h)
        {
        }

        public int Delete(int id)
        {
            HotelProvider provider = new HotelProvider();

            return provider.RemoveHotel(id);
        }
    }
}
