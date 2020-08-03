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
    public class HotelProvider
    {
        public IEnumerable<HotelView> GetHoteli()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<HotelView> hoteli = s.Query<Hotel>()
                                                .Select(p => new HotelView(p));
            return hoteli;
        }

        public HotelView GetHotel(int id)
        {
            ISession s = DataLayer.GetSession();

            Hotel hotel = s.Query<Hotel>()
                .Where(v => v.IdSmestaja == id).Select(p => p).FirstOrDefault();

            if (hotel == null) return new HotelView();

            return new HotelView(hotel);
        }

        public int AddHotel(Hotel a)
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

        public int EditHotel(Hotel h)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hotel hotel = s.Query<Hotel>()
                .Where(v => v.IdSmestaja == h.IdSmestaja).Select(p => p).FirstOrDefault();

                hotel.Sifra = h.Sifra;
                hotel.Ime = h.Ime;
                hotel.Br_lezaja = h.Br_lezaja;
                hotel.Adresa = h.Adresa;
                hotel.Kategorija = h.Kategorija;
                hotel.Grad = h.Grad;
                hotel.Restoran_mesta = h.Restoran_mesta;
                hotel.Direktor = h.Direktor;

                s.Update(hotel);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveHotel(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hotel a = s.Load<Hotel>(id);

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
