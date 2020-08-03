using NHibernate;
using Prodavnica.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Prodavnica.DTOs;

namespace Prodavnica
{
    public class DataProvider
    {
        public IEnumerable<Vojnik> GetVojnici()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Vojnik> proizvodi = s.Query<Vojnik>()
                                                //.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
                                                //.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
                                                .Select(p => p);
            return proizvodi;
        }

        public Vojnik GetVojnik(int barkod)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Vojnik>()
                .Where(v => v.BarKod == barkod).Select(p => p).FirstOrDefault();
        }

        public VojnikView GetVojnikView(int barkod)
        {
            ISession s = DataLayer.GetSession();

            Vojnik voj = s.Query<Vojnik>()
                .Where(v => v.BarKod == barkod).Select(p => p).FirstOrDefault();

            if (voj == null) return new VojnikView();

            return new VojnikView(voj);
        }

        public int AddVojnik(Vojnik v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveVojnik(int barkod)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vojnik v = s.Load<Vojnik>(barkod);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch(Exception exc)
            {
                return -1;
            }

        }
    }
}
