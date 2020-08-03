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
   public  class ApartmanProvider
    {
        public IEnumerable<ApartmanView> GetApartmani()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ApartmanView> apartmani = s.Query<Apartman>()
                                                .Select(p => new ApartmanView(p));
            return apartmani;
        }

        public ApartmanView GetApartmanView(int id)
        {
            ISession s = DataLayer.GetSession();

            Apartman ap = s.Query<Apartman>()
                .Where(v => v.IdSmestaja == id).Select(p => p).FirstOrDefault();

            if (ap == null) return new ApartmanView();

            return new ApartmanView(ap);
        }

        public int AddApartman(Apartman a)
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

        public int EditApartman(Apartman a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apartman ap = s.Query<Apartman>()
                .Where(v => v.IdSmestaja == a.IdSmestaja).Select(p => p).FirstOrDefault();

                ap.ImeVlasnika = a.ImeVlasnika;
                ap.PrezimeVlasnika = a.PrezimeVlasnika;
                ap.Telefon = a.Telefon;
                ap.TipApartmana = a.TipApartmana;

                s.Update(ap);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveApartman(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apartman a = s.Load<Apartman>(id);

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
