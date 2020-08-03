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
    public class RezervacijaProvider
    {
        public IEnumerable<RezervacijaView> GetRezervacije()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<RezervacijaView> rez = s.Query<Rezervacija>()
                                                .Select(p => new RezervacijaView(p));
            return rez;
        }

        public RezervacijaView GetRezervacijaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Rezervacija rezervacija = s.Query<Rezervacija>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (rezervacija == null) return new RezervacijaView();

            return new RezervacijaView(rezervacija);
        }

        public int AddRezervacija(Rezervacija a)
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

        public int EditRezervacija(Rezervacija r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija rez = s.Query<Rezervacija>()
                .Where(v => v.Id == r.Id).Select(p => p).FirstOrDefault();

                rez.TipRezervacije = r.TipRezervacije;
                rez.TipUsluge = r.TipUsluge;
                rez.Od = r.Od;
                rez.Do = r.Do;

                s.Update(rez);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveRezervacija(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija a = s.Load<Rezervacija>(id);

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
