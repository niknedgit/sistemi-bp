using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPdeo1.Entiteti;
using NHibernate;

namespace BPdeo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaziGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Grupa g = s.Load<Grupa>(21);

                MessageBox.Show(g.Naziv);

                foreach (Klijent k in g.Klijenti)
                {
                    MessageBox.Show(k.Ime + " " + k.Prezime + " pripada ovoj grupi");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnNapraviKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //jmbg mora biti unique,pa se ne moze dva puta kreirati klijent sa istim jmbg-om
                Klijent k = new Klijent();

                k.Ime = "Stojana";
                k.Prezime = "Rakic";
                k.Jmbg = "0905977745099";
                k.Dat_rodj = DateTime.Parse("9.5.1977.");
                k.PripadaGrupi = s.Load<Grupa>(21);

                s.Save(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnGdePripada_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dete d = s.Load<Dete>(31);

                MessageBox.Show(d.Ime + " je dete roditelja: " + d.Roditelj.Ime + " " + d.Roditelj.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnSobeHotela_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hotel h = s.Load<Hotel>(23);

                foreach (Soba soba in h.ImaSobe)
                {
                    MessageBox.Show("Broj sobe: " + soba.Broj + ", broj kreveta: " + soba.Tip);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUslugaSoba_Click(object sender, EventArgs e)
        {


            try
            {
                ISession s = DataLayer.GetSession();

                Usluga u = s.Load<Usluga>(23);
                Entiteti.Soba soba = s.Load<Entiteti.Soba>(21);

                VezanaJe vezana_je = new VezanaJe();
                vezana_je.Soba = soba;
                vezana_je.Usluga = u;
                vezana_je.Cena = 2550;

                s.Save(vezana_je);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Jednokrevetna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Hotel h = s.Load<Entiteti.Hotel>(26);
                
                Jednokrevetna j1 = new Jednokrevetna()
                {
                    Broj = 14,
                    Sprat = 2,
                    Radio ="DA",
                    Tv ="NE",
                    Kupatilo = "DA",
                    Klima = "DA",
                    Slobodno = "DA",
                    More = "NE",
                    Frizider = "DA",
                    PripadaHotelu = h
                };

                s.Save(j1);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Dvokrevetna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Hotel h = s.Load<Entiteti.Hotel>(24);
                
                Dvokrevetna d1 = new Dvokrevetna()
                {
                    Broj = 35,
                    Sprat = 4,
                    Radio = "DA",
                    Tv = "NE",
                    Kupatilo = "DA",
                    Klima = "NE",
                    Slobodno = "DA",
                    More = "DA",
                    Frizider = "DA",
                    PripadaHotelu = h
                };

                s.Save(d1);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void UcitajKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BPdeo1.Entiteti.Klijent k = s.Load<BPdeo1.Entiteti.Klijent>(28);

                MessageBox.Show("Ucitan je klijent " + k.Ime + " " + k.Prezime );

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Grupa g = new Entiteti.Grupa();

                g.Naziv = "Grupa 4";

                s.SaveOrUpdate(g);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajHotel_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Okruzenje o = s.Load<Entiteti.Okruzenje>(21);

                Hotel h = new Hotel();

                h.Sifra = "567";
                h.Ime = "Plaza";
                h.Br_lezaja = 73;
                h.Adresa = "Topolska 18";
                h.Kategorija = "Dve";
                h.Grad = "Beograd";
                h.Restoran_mesta = 43;
                h.Direktor = "Jovan Jovanovic";
                h.PripadaOkruzenju = o;

                s.Save(h);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajApartman_Click(object sender, EventArgs e)
        { 
            try
            {
                ISession s = DataLayer.GetSession();

                Okruzenje o = s.Load<Okruzenje>(22);

                Garsonjera g = new Garsonjera();

                g.ImeVlasnika = "Boban";
                g.PrezimeVlasnika = "Bakic";   
                g.Telefon = "062254879";
                g.PripadaOkruzenju = o;


                s.Save(g);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BPdeo1.Entiteti.Hotel h = s.Load<BPdeo1.Entiteti.Hotel>(23);

                MessageBox.Show("Ucitan je Hotel " + h.Ime + ", koji se nalazi u " + h.Grad);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Ucitajapartman_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Apartman a = s.Load<Apartman>(33);

                MessageBox.Show("Ucitan je apartman vlasnika " + a.ImeVlasnika + " " + a.PrezimeVlasnika + ", broj telefona " + a.Telefon );

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajDete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
           

                Klijent k = s.Load<Klijent>(32);

                Dete d = new Dete()
                {
                    Ime = "Nikolija",
                    Prezime = "Janjic",
                    Uzrast = 10,
                    
                };

                d.Roditelj = k;
                s.Save(d);

                k.Deca.Add(d);
               
                s.Save(k);

                foreach (Dete dete in k.Deca)
                {
                    MessageBox.Show(dete.Ime + " " + dete.Prezime);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void DodatneUslugeKreiraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Okruzenje o = s.Load<Entiteti.Okruzenje>(24);

                DodatneUslugeOkruzenje d = new DodatneUslugeOkruzenje();

                d.Usluga = "Masaza";
                d.PripadaOkruznju = o;

                s.Save(d);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajSport_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Hotel h = s.Load<Entiteti.Hotel>(25);

                SportskeAktivnosti sa = new SportskeAktivnosti();

                sa.Aktivnost = "Plivanje";
                sa.PripadaHotelu = h;

                s.Save(sa);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SportskeAktivnosti sa = s.Load<SportskeAktivnosti>(23);
              
                MessageBox.Show(sa.Aktivnost);
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void MedTretmanKreiraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MedicinskiTretman m1 = s.Load<MedicinskiTretman>(23);

                foreach (Entiteti.Okruzenje o in m1.OkruzenjeTretman)
                {
                    MessageBox.Show("" +o.Id ); 
                }

                Okruzenje o1 = s.Load<Okruzenje>(21);

                foreach (MedicinskiTretman med in o1.MedicinskiTretmani)
                {
                    MessageBox.Show(med.ImeLekara + " , " + med.Specijalnost);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void RezApartman_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija r = s.Load<Rezervacija>(62);
                Klijent k = s.Load<Klijent>(66);

                PraviRez pr = new PraviRez();
                pr.ImeKlijenta = k.Ime;
                pr.PrezimeKlijenta = k.Prezime;
                pr.JmbgKlijenta = k.Jmbg;
                pr.DatRodj = k.Dat_rodj;
                pr.Od = r.Od;
                pr.Do = r.Do;
                pr.TipUsluge = r.TipUsluge;
                pr.Klijent = k;
                pr.Rezervacija = r;

                s.Save(pr);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void RezSoba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Rezervacija r = s.Load<Rezervacija>(61);
                Klijent k = s.Load<Klijent>(49);

                PraviRez pr = new PraviRez();
                pr.ImeKlijenta = k.Ime;
                pr.PrezimeKlijenta = k.Prezime;
                pr.JmbgKlijenta = k.Jmbg;
                pr.DatRodj = k.Dat_rodj;
                pr.Od = r.Od;
                pr.Do = r.Do;
                pr.TipUsluge = r.TipUsluge;
                pr.Klijent = k;
                pr.Rezervacija = r;

                s.Save(pr);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hotel h = s.Load<Hotel>(21);

                foreach (Usluga u in h.ImaUsluge)
                {
                    MessageBox.Show("" + u.Id);
                }

                Usluga u1 = s.Load<Usluga>(22);

                foreach (Hotel h1 in u1.ImaHotele)
                {
                    MessageBox.Show(h1.Direktor);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreirajMedT_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Okruzenje o = s.Load<Okruzenje>(23);

                MedicinskiTretman mt = new MedicinskiTretman();

                mt.ImeLekara = "Aleksandar";
                mt.Specijalnost = "Fizioterapeut";
                mt.OkruzenjeTretman.Add(o);
                s.Save(mt);

                o.MedicinskiTretmani.Add(mt);
                s.Save(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}

