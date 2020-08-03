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
    public class SportskeAktivnostiController : ApiController
    {


        public IEnumerable<SportskeAktivnostiView> Get()
        {
            SportskeAktivnostiProvider provider = new SportskeAktivnostiProvider();

            IEnumerable<SportskeAktivnostiView> aktivnosti = provider.GetSportskeAktivnosti();

            return aktivnosti;
        }

        public SportskeAktivnostiView Get(int id)
        {
            SportskeAktivnostiProvider provider = new SportskeAktivnostiProvider();

            return provider.GetSportskeAktivnostiView(id);
        }

        public int Post([FromBody]SportskeAktivnosti sa)
        {
            SportskeAktivnostiProvider provider = new SportskeAktivnostiProvider();

            return provider.AddSportskeAktivnosti(sa);
        }

        public int Put([FromBody]SportskeAktivnosti sa)
        {
            SportskeAktivnostiProvider provider = new SportskeAktivnostiProvider();

            return provider.EditSportkeAktivnosti(sa);
        }

        public int Delete(int id)
        {
            SportskeAktivnostiProvider provider = new SportskeAktivnostiProvider();

            return provider.RemoveSportskeAktivnosti(id);
        }
    }
}
