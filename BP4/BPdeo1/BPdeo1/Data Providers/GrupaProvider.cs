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
   public class GrupaProvider
    {
        public IEnumerable<GrupaView> GetGrupe()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<GrupaView> grupe = s.Query<Grupa>()
                                                .Select(p => new GrupaView(p));
            return grupe;
        }

        public GrupaView GetGrupaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Grupa grupa = s.Query<Grupa>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (grupa == null) return new GrupaView();

            return new GrupaView(grupa);
        }

        public int AddGrupa(Grupa a)
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

        public int EditGrupa(Grupa g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grupa grupa = s.Query<Grupa>()
                .Where(v => v.Id == g.Id).Select(p => p).FirstOrDefault();

                grupa.Naziv = g.Naziv;

                s.Update(grupa);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveGrupa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grupa a = s.Load<Grupa>(id);

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
