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
    public class MedicinskiTretmanController : ApiController
    {


        public IEnumerable<MedicinskiTretmanView> Get()
        {
            MedicinskiTretmanProvider provider = new MedicinskiTretmanProvider();

            IEnumerable<MedicinskiTretmanView> tretmani = provider.GetMedicinskiTretmani();

            return tretmani;
        }

        public MedicinskiTretmanView Get(int id)
        {
            MedicinskiTretmanProvider provider = new MedicinskiTretmanProvider();

            return provider.GetMedicinskiTretmanView(id);
        }

        public int Post([FromBody]MedicinskiTretman m)
        {
            MedicinskiTretmanProvider provider = new MedicinskiTretmanProvider();

            return provider.AddMedicinskiTretman(m);
        }

        public int Put([FromBody]MedicinskiTretman m)
        {
            MedicinskiTretmanProvider provider = new MedicinskiTretmanProvider();

            return provider.EditMedTretman(m);
        }

        public int Delete(int id)
        {
            MedicinskiTretmanProvider provider = new MedicinskiTretmanProvider();

            return provider.RemoveMedicinskiTretman(id);
        }
    }
}
