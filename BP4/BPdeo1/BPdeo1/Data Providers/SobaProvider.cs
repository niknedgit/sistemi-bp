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
    public class SobaProvider
    {
        public IEnumerable<SobaView> GetSobe()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<SobaView> sobe = s.Query<Soba>()
                                                .Select(p => new SobaView(p));
            return sobe;
        }

        public SobaView GetSobaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Soba soba = s.Query<Soba>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (soba == null) return new SobaView();

            return new SobaView(soba);
        }

        public int AddSoba(Soba a)
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

        public int EditSoba(Soba so)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Soba soba = s.Query<Soba>()
                .Where(v => v.Id == so.Id).Select(p => p).FirstOrDefault();

                soba.Broj = so.Broj;
                soba.Sprat = so.Sprat;
                soba.Radio = so.Radio;
                soba.Tv = so.Tv;
                soba.Kupatilo = so.Kupatilo;
                soba.Klima = so.Klima;
                soba.Slobodno = so.Slobodno;
                soba.More = so.More;
                soba.Frizider = so.Frizider;
                soba.Tip = so.Tip;

                s.Update(soba);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveSoba(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Soba a = s.Load<Soba>(id);

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
