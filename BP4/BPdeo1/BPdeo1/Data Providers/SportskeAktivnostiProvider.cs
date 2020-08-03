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
    public class SportskeAktivnostiProvider
    {
        public IEnumerable<SportskeAktivnostiView> GetSportskeAktivnosti()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<SportskeAktivnostiView> sportske = s.Query<SportskeAktivnosti>()
                                                .Select(p => new SportskeAktivnostiView(p));
            return sportske;
        }

        public SportskeAktivnostiView GetSportskeAktivnostiView(int id)
        {
            ISession s = DataLayer.GetSession();

            SportskeAktivnosti sportske = s.Query<SportskeAktivnosti>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (sportske == null) return new SportskeAktivnostiView();

            return new SportskeAktivnostiView(sportske);
        }

        public int AddSportskeAktivnosti(SportskeAktivnosti a)
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

        public int EditSportkeAktivnosti(SportskeAktivnosti sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SportskeAktivnosti sportska = s.Query<SportskeAktivnosti>()
                .Where(v => v.Id == sp.Id).Select(p => p).FirstOrDefault();

                sportska.Aktivnost = sp.Aktivnost;

                s.Update(sportska);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveSportskeAktivnosti(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SportskeAktivnosti a = s.Load<SportskeAktivnosti>(id);

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
