using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPdeo1.DTOs;
using BPdeo1.Entiteti;
using NHibernate;

namespace BPdeo1.Data_Providers
{
    public class UslugaProvider
    {
        public IEnumerable<UslugaView> GetUsluge()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<UslugaView> usluge = s.Query<Usluga>()
                                                .Select(p => new UslugaView(p));
            return usluge;
        }

        public UslugaView GetUslugaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Usluga usluga = s.Query<Usluga>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (usluga == null) return new UslugaView();

            return new UslugaView(usluga);
        }

        public int AddUsluga(Usluga a)
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

        public int EditUsluga(Usluga u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Usluga usluga = s.Query<Usluga>()
                .Where(v => v.Id == u.Id).Select(p => p).FirstOrDefault();

                usluga.TipUsluge = u.TipUsluge;

                s.Update(usluga);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveUsluga(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Usluga a = s.Load<Usluga>(id);

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
