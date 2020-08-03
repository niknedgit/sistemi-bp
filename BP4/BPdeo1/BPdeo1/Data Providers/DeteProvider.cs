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
    public class DeteProvider
    {
        public IEnumerable<DeteView> GetDeca()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<DeteView> deca = s.Query<Dete>()
                                                .Select(p => new DeteView(p));
            return deca;
        }

        public DeteView GetDeteView(int id)
        {
            ISession s = DataLayer.GetSession();

            Dete dete = s.Query<Dete>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (dete == null) return new DeteView();

            return new DeteView(dete);
        }

        public int AddDete(Dete a)
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

        public int EditDete(Dete d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dete dete = s.Query<Dete>()
                .Where(v => v.Id == d.Id).Select(p => p).FirstOrDefault();

                dete.Ime = d.Ime;
                dete.Prezime = d.Prezime;
                dete.Uzrast = d.Uzrast;
                //dete.Roditelj = d.Jmbg;

                s.Update(dete);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveDete(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dete a = s.Load<Dete>(id);

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
