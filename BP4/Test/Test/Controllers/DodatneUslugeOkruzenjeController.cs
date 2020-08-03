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
    public class DodatneUslugeOkruzenjeController : ApiController
    {


        public IEnumerable<DodatneUslugeOkruzenjeView> Get()
        {
            DodatneUslugeOkruzenjaProvider provider = new DodatneUslugeOkruzenjaProvider();

            IEnumerable<DodatneUslugeOkruzenjeView> usluge = provider.GetDodatneUsluge();

            return usluge;
        }

        public DodatneUslugeOkruzenjeView Get(int id)
        {
            DodatneUslugeOkruzenjaProvider provider = new DodatneUslugeOkruzenjaProvider();

            return provider.GetDodatneUslugeOkruzenjeView(id);
        }

        public int Post([FromBody]DodatneUslugeOkruzenje duo)
        {
            DodatneUslugeOkruzenjaProvider provider = new DodatneUslugeOkruzenjaProvider();

            return provider.AddDodatneUslugeOkruzenje(duo);
        }

        public int Put([FromBody]DodatneUslugeOkruzenje duo)
        {
            DodatneUslugeOkruzenjaProvider provider = new DodatneUslugeOkruzenjaProvider();

            return provider.EditDodatnaUsluga(duo);
        }

        public int Delete(int id)
        {
            DodatneUslugeOkruzenjaProvider provider = new DodatneUslugeOkruzenjaProvider();

            return provider.RemoveDodatneUslugeOkruzenje(id);
        }
    }
}
