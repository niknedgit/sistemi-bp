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
    public class KlijentProvider
    {
        public IEnumerable<KlijentView> GetKlijenti()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<KlijentView> klijenti = s.Query<Klijent>()
                                                .Select(p => new KlijentView(p));
            return klijenti;
        }

        public KlijentView GetKlijentView(int id)
        {
            ISession s = DataLayer.GetSession();

            Klijent klijent = s.Query<Klijent>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (klijent == null) return new KlijentView();

            return new KlijentView(klijent);
        }

        public int AddKlijent(Klijent a)
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

        public int EditKlijent(Klijent k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klijent klijent = s.Query<Klijent>()
                .Where(v => v.Id == k.Id).Select(p => p).FirstOrDefault();

                klijent.Ime = k.Ime;
                klijent.Prezime = k.Prezime;
                klijent.Dat_rodj = k.Dat_rodj;
                klijent.Jmbg = k.Jmbg;

                s.Update(klijent);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveKlijent(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klijent a = s.Load<Klijent>(id);

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
