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
    public class MedicinskiTretmanProvider
    {
        public IEnumerable<MedicinskiTretmanView> GetMedicinskiTretmani()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<MedicinskiTretmanView> medicinskiTretmani = s.Query<MedicinskiTretman>()
                                                .Select(p => new MedicinskiTretmanView(p));
            return medicinskiTretmani;
        }

        public MedicinskiTretmanView GetMedicinskiTretmanView(int id)
        {
            ISession s = DataLayer.GetSession();

            MedicinskiTretman medicinskiTretman = s.Query<MedicinskiTretman>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (medicinskiTretman == null) return new MedicinskiTretmanView();

            return new MedicinskiTretmanView(medicinskiTretman);
        }

        public int AddMedicinskiTretman(MedicinskiTretman a)
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

        public int EditMedTretman(MedicinskiTretman mt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MedicinskiTretman medicinski = s.Query<MedicinskiTretman>()
                .Where(v => v.Id == mt.Id).Select(p => p).FirstOrDefault();

                medicinski.ImeLekara = mt.ImeLekara;
                medicinski.Specijalnost = mt.Specijalnost;

                s.Update(medicinski);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveMedicinskiTretman(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MedicinskiTretman a = s.Load<MedicinskiTretman>(id);

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
