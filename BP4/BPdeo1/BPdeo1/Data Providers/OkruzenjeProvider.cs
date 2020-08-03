using BPdeo1.DTOs;
using BPdeo1.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPdeo1.Data_Providers
{
    public class OkruzenjeProvider
    {
        public IEnumerable<OkruzenjeView> GetOkruzenja()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<OkruzenjeView> okruzenja = s.Query<Okruzenje>()
                                                .Select(p => new OkruzenjeView(p));
            return okruzenja;
        }

        public OkruzenjeView GetOkruzenjeView(int id)
        {
            ISession s = DataLayer.GetSession();

            Okruzenje okruzenje = s.Query<Okruzenje>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (okruzenje == null) return new OkruzenjeView();

            return new OkruzenjeView(okruzenje);
        }

        public int AddOkruzenje(Okruzenje a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int EditOkruzenje(Okruzenje o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Okruzenje okruzenje = s.Query<Okruzenje>()
                .Where(v => v.Id == o.Id).Select(p => p).FirstOrDefault();

                okruzenje.TipOkruzenja = o.TipOkruzenja;

                s.Update(okruzenje);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveOkruzenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Okruzenje a = s.Load<Okruzenje>(id);

                s.Delete(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }
    }
}
