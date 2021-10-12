using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkPrirode.Entiteti;

namespace ParkPrirode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitajOblast_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(1);
                MessageBox.Show("Ime: " + o.Ime + "\nPovrsina: " + o.Povrsina);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajBiljku_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b = s.Load<Biljka>(1);
                MessageBox.Show("Latinski naziv: " + b.Latinski_naziv);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVezaMto1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b = s.Load<Biljka>(7);
                foreach(LokalniNazivBiljke lnb in b.LokalniNazivi)
                {
                    MessageBox.Show("Latinski naziv : " + b.Latinski_naziv + "\nLokalni naziv: " + lnb.id.Lokalni_naziv);
                }
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLoadZasticenaBiljka_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZasticenaBiljka a = s.Load<ZasticenaBiljka>(1);
                MessageBox.Show("Latinski naziv : " + a.Latinski_naziv + "\nBroj odluke: " + a.Broj_odluke);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajOblasti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Oblast");

                IList<Oblast> oblasti = q.List<Oblast>();

                foreach(Oblast o in oblasti)
                {
                    MessageBox.Show("Ime: " + o.Ime + "\nTip zastite: " + o.Tip_zastite);
                }
                s.Close();
            }
            catch (Exception ec) {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajSela1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(1);
                foreach (NazivSelaOblast nso in o.Naziv_sela)
                {
                    MessageBox.Show("Naziv oblasti : " +o.Ime  + "\nNaziv sela: " + nso.id.Naziv_sela);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdHasManyToManyOB_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b1 = s.Load<Biljka>(1);
                foreach(Oblast o in b1.Oblasti)
                {
                    MessageBox.Show("Biljka :" + b1.Latinski_naziv + " se nalazi u oblasti: " + o.Ime);
                }

                Oblast o1 = s.Load<Oblast>(1);
                foreach (Biljka b2 in o1.Biljke)
                {
                    MessageBox.Show("Oblast :" + o1.Ime + " sadrzi biljke: " + b2.Latinski_naziv);
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajZivotinju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z = s.Load<Zivotinja>(1);
                MessageBox.Show("Serijski broj prstena: " + z.Serijski_broj_prstena + "\nLokalni naziv: " + z.Lokalni_naziv + "\nLatinski naziv: " + z.Latinski_naziv);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajPticuSelicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja");
                IList<Zivotinja> zivotinje = q.List<Zivotinja>();

                foreach (Zivotinja z in zivotinje)
                {
                    if (z.GetType() == typeof(Ptice_selice))
                    {
                        MessageBox.Show("Lokalni naziv: " + z.Lokalni_naziv + "\nPtica selica: da ");
                    }
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdZemljePticeSelice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja as z where z.Id_zivotinje = 9");
                Zivotinja zivotinja = q.UniqueResult<Zivotinja>();
                if (zivotinja.GetType() == typeof(Ptice_selice))
                {
                    Ptice_selice ps = (Ptice_selice)zivotinja;
                    foreach(PticeSeliceZivotinje psz in ps.zemlje)
                    {
                        MessageBox.Show("Ptica: " + ps.Lokalni_naziv + "\nZemlja kroz koju prolazi: " + psz.id.Zemlje);
                    }
                }
                else
                {
                    MessageBox.Show("Nije ptica selica");
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToManyOblastZivotinja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z1 = s.Load<Zivotinja>(1);
                foreach (Oblast o in z1.Oblasti)
                {
                    MessageBox.Show("Zivotinja :" + z1.Lokalni_naziv + " se nalazi u oblasti: " + o.Ime);
                }

                Oblast o1 = s.Load<Oblast>(1);
                foreach (Zivotinja z2 in o1.Zivotinje)
                {
                    MessageBox.Show("Oblast :" + o1.Ime + " sadrzi zivotinje: " + z2.Lokalni_naziv);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void cmdUcitajRadnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Radnik r = s.Load<Radnik>(4);
                MessageBox.Show("Ime: " + r.Ime + "\nPrezime: " + r.Prezime + "\nAdresa: " + r.Adresa + "\nPripada oblasti: " + r.pripadaOblasti.Ime); 
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdRadniciVolonteriStalnoZaposljeni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Radnik");

                IList<Radnik> radnici = q.List<Radnik>();

                foreach (Radnik r in radnici)
                {
                   if(r.GetType() == typeof(Volonter))
                    {
                        MessageBox.Show("Ime: " + r.Ime + "\nPrezime: " + r.Prezime + "\nVolonter");
                    }
                   else if (r.GetType() == typeof(StalnoZaposlen))
                    {
                        StalnoZaposlen r1 = (StalnoZaposlen)r;
                        MessageBox.Show("Ime: " + r1.Ime + "\nPrezime: " + r1.Prezime + "\nStalno zaposljen" 
                            + "\nBroj radne knjizice: " + r1.Broj_radne_knjizice 
                            + "\nBroj licne karte: " + r1.Broj_licne_karte 
                            + "\nMesto izdavanja: " + r1.Mesto_izdavanja_lk);
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajRadnikeOblasti1_Click(object sender, EventArgs e)
        {
            try { 
                  ISession s = DataLayer.GetSession();

                  Oblast o = s.Load<Oblast>(1);

                  foreach (Radnik r in o.Radnici)
                  {
                     if (r.GetType() == typeof(Volonter))
                     {
                             MessageBox.Show("Ime: " + r.Ime + "\nPrezime: " + r.Prezime + "\nVolonter");
                     }
                     else if (r.GetType() == typeof(StalnoZaposlen))
                     {
                            StalnoZaposlen r1 = (StalnoZaposlen)r;
                             MessageBox.Show("Ime: " + r1.Ime + "\nPrezime: " + r1.Prezime + "\nStalno zaposljen"
                                 + "\nBroj radne knjizice: " + r1.Broj_radne_knjizice
                                   + "\nBroj licne karte: " + r1.Broj_licne_karte
                                     + "\nMesto izdavanja: " + r1.Mesto_izdavanja_lk);
                     }
                  }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajHraniliste_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste h = s.Load<Hraniliste>(2);
                MessageBox.Show("Oblast: "+ h.PripadaOblasti.Ime + "\nPocetni mesec: " + h.Pocetni_datum + "\nKrajnji mesec: " + h.Krajnji_datum);
                
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdZivotinjaPrimecena_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Hraniliste h = s.Load<Hraniliste>(2);
                foreach(Primecena_je z in h.PrimecenaJeZivotinja)
                {
                    MessageBox.Show("Hraniliste: " + h.PripadaOblasti.Ime + "\nZivotinja: " + z.Id.Id_zivotinje.Lokalni_naziv + "\nDatuma: " + z.Datum_vidjenja);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPogledOblasti_Click(object sender, EventArgs e)
        {
            OblastInformacije odInfoForm = new OblastInformacije();
            odInfoForm.Show();

          /*  try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Oblast");
                IEnumerable<Oblast> Oblasti = q.Enumerable<Oblast>();
                foreach (Oblast o in Oblasti)
                {
                    MessageBox.Show(o.Id_oblasti +"\n" + o.Ime + "\n" + 
                        o.Povrsina + "\n" + o.Naziv_sela.Count + "\n" + 
                        o.Zivotinje.Count + "\n" + o.Biljke.Count + "\n" + o.Radnici.Count
                        + "\n" + o.Hranilista.Count);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
        }

        private void cmdPogledajBiljke_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka");
                IEnumerable<Biljka> biljke = q.Enumerable<Biljka>();
                foreach (Biljka b in biljke)
                {
                    if (b.GetType().IsSubclassOf(typeof(ZasticenaBiljka)))
                    {
                        MessageBox.Show(b.Latinski_naziv + " Da");
                    }
                    else
                    {
                        MessageBox.Show(b.Latinski_naziv + " Ne");
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitajRadnike_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Radnik");
                IList<Radnik> radnici = q.List<Radnik>();
                foreach (Radnik r in radnici)
                {
                    MessageBox.Show(r.Ime);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
