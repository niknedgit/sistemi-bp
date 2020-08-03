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
    public class DodatneUslugeOkruzenjaProvider
    {
        public IEnumerable<DodatneUslugeOkruzenjeView> GetDodatneUsluge()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<DodatneUslugeOkruzenjeView> dod = s.Query<DodatneUslugeOkruzenje>()
                                                .Select(p => new DodatneUslugeOkruzenjeView(p));
            return dod;
        }

        public DodatneUslugeOkruzenjeView GetDodatneUslugeOkruzenjeView(int id)
        {
            ISession s = DataLayer.GetSession();

            DodatneUslugeOkruzenje dodatne = s.Query<DodatneUslugeOkruzenje>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (dodatne == null) return new DodatneUslugeOkruzenjeView();

            return new DodatneUslugeOkruzenjeView(dodatne);
        }

        public int AddDodatneUslugeOkruzenje(DodatneUslugeOkruzenje a)
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

        public int EditDodatnaUsluga(DodatneUslugeOkruzenje d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatneUslugeOkruzenje dodatna = s.Query<DodatneUslugeOkruzenje>()
                .Where(v => v.Id == d.Id).Select(p => p).FirstOrDefault();

                dodatna.Usluga = d.Usluga;

                s.Update(dodatna);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveDodatneUslugeOkruzenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatneUslugeOkruzenje a = s.Load<DodatneUslugeOkruzenje>(id);

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
