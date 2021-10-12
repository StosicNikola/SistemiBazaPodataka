using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode.Entiteti;
using NHibernate.Linq;
using NHibernate;

namespace ParkPrirode
{
    public class DTOManager
    {
        #region Oblast
        public static List<OblastPregled> GetObInfos()
        {
            List<OblastPregled> obInfos = new List<OblastPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Oblast");
                IEnumerable<Oblast> Oblasti = q.Enumerable<Oblast>();
                foreach(Oblast o in Oblasti)
                {
                    if (NHibernateUtil.GetClass(o) == typeof(OblastMonitoring))
                    {
                        obInfos.Add(new OblastMonitoringPogled(o.Id_oblasti, o.Ime, o.Povrsina, o.Naziv_sela.Count, o.Zivotinje.Count, o.Biljke.Count, o.Radnici.Count, o.Hranilista.Count, "Monitoring"));
                    }
                    else if (NHibernateUtil.GetClass(o) == typeof(OblastStalnaZastita))
                    {
                        obInfos.Add(new OblastStalnaZastitaPogled(o.Id_oblasti, o.Ime, o.Povrsina, o.Naziv_sela.Count, o.Zivotinje.Count, o.Biljke.Count, o.Radnici.Count, o.Hranilista.Count, "Stalna zastita"));
                    }
                    else if (NHibernateUtil.GetClass(o) == typeof(OblastPovremenaZastita))
                    {
                        obInfos.Add(new OblastPovremenaIntervencijaPogled(o.Id_oblasti, o.Ime, o.Povrsina, o.Naziv_sela.Count, o.Zivotinje.Count, o.Biljke.Count, o.Radnici.Count, o.Hranilista.Count, "Povremena intervencija"));
                    }
                }

                s.Close();
            }
            catch(Exception ec)
            {
               
            }

            return obInfos;
        }

        public static List<OblastBasic> GetOblasti()
        {
            List<OblastBasic> obInfos = new List<OblastBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Oblast");
                IEnumerable<Oblast> Oblasti = q.Enumerable<Oblast>();
                foreach (Oblast o in Oblasti)
                {
                    if (NHibernateUtil.GetClass(o) == typeof(OblastMonitoring))
                    {
                        obInfos.Add(new MonitoringBasic(o.Id_oblasti, o.Ime, o.Povrsina,"Monitoring"));
                    }
                    else if(NHibernateUtil.GetClass(o) == typeof(OblastStalnaZastita))
                    {
                        obInfos.Add(new StalnaZastitaBasic(o.Id_oblasti, o.Ime, o.Povrsina, "Stalna zastita"));
                    }
                    else if (NHibernateUtil.GetClass(o) == typeof(OblastPovremenaZastita))
                    {
                        obInfos.Add(new PovremenaIntervencijaBasic(o.Id_oblasti, o.Ime, o.Povrsina, "Povremena intervencija"));
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {

            }

            return obInfos;
        }

        public static List<NazivSelaOblastBasic> GetNazivSela(int idOblasti)
        {
            List<NazivSelaOblastBasic> sela = new List<NazivSelaOblastBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(idOblasti);
                OblastBasic on = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach (NazivSelaOblast nso in o.Naziv_sela) {
                    sela.Add(new NazivSelaOblastBasic(on, nso.id.Naziv_sela));
                }
                s.Close();
            }
            catch
            {

            }
            return sela;
        }

        public static void DodajNazivSelaOblasti(String ime, int idOblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(idOblast);
                NazivSelaOblast selo = new NazivSelaOblast();
                selo.id.Id_oblastiFK = oblast;
                selo.id.Naziv_sela = ime;
                s.Save(selo);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static bool ObrisiNazivSelaOblast(String ime)
        {
            bool test;
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from NazivSelaOblast as l where l.id.Naziv_sela =?");
                q.SetParameter(0, ime);
                NazivSelaOblast selo = q.UniqueResult<NazivSelaOblast>();

                s.Delete(selo);
                s.Flush();
                s.Close();
                test = true;

            }
            catch (Exception ec)
            {
                test = false;
            }
            return test;
        }

        public static void DodajOblast(OblastBasic oblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                if(oblast.GetType() == typeof(MonitoringBasic))
                {
                    OblastMonitoring o = new OblastMonitoring();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
                else if (oblast.GetType() == typeof(PovremenaIntervencijaBasic))
                {
                    OblastPovremenaZastita o = new OblastPovremenaZastita();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
                else if (oblast.GetType() == typeof(StalnaZastitaBasic))
                {
                    OblastStalnaZastita o = new OblastStalnaZastita();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
            }
            catch(Exception ec)
            {

            }
        }

        public static void IzmeniOblast(OblastBasic oblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(oblast.OblastId);
                o.Ime = oblast.Ime;
                o.Povrsina = oblast.Povrsina;
                s.Update(o);
                s.Flush();
                s.Close();
                
            }
            catch (Exception ec)
            {

            }
        }

        public static void ObrisiOblast(int idOblasti)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oblast o = s.Load<Oblast>(idOblasti);

                s.Delete(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }
        #endregion

        #region BiljkaForm
        public static List<BiljkaPregled> GetBiljkaInfos() {
            List<BiljkaPregled> biljkaInfos = new List<BiljkaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka");
                IEnumerable<Biljka> biljke = q.Enumerable<Biljka>();
                foreach (Biljka b in biljke)
                {
                //    Type bt = b.GetType(); Asistent objasnjenje!!
                  //  Type zbt = typeof(ZasticenaBiljka);

              /*      var btt = NHibernateUtil.GetClass(b);

                    bool t = btt.IsSubclassOf(typeof(Biljka));

                    bool zb = btt == typeof(ZasticenaBiljka);*/

                    if (NHibernateUtil.GetClass(b) == typeof(ZasticenaBiljka))
                    {
                        biljkaInfos.Add(new BiljkaPregled(b.Id_biljke, b.Latinski_naziv, "Da"));
                    }
                    else
                    {
                        biljkaInfos.Add(new BiljkaPregled(b.Id_biljke, b.Latinski_naziv, "Ne"));
                    }
                }
                s.Close();
            }
            catch(Exception ec)
            {

            }
            return biljkaInfos;
        }

        public static BiljkaBasic GetBiljka(int id)
        {
            BiljkaBasic biljka = new BiljkaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b = s.Load<Biljka>(id);
                
                biljka.BiljkaId = b.Id_biljke;
                biljka.LatinskiNaziv = b.Latinski_naziv;
                foreach(LokalniNazivBiljke lnb in b.LokalniNazivi)
                {
                    LokalniNazivBiljkeBasic lnbb = new LokalniNazivBiljkeBasic(lnb.id.Lokalni_naziv);
                    biljka.DodajLokalniNaziv(lnbb);
                }
                foreach (Oblast o in b.Oblasti) {
                    OblastBasic o1 = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                    biljka.pripadaOblasti.Add(o1);
                }
                s.Close();
               
            }
            catch(Exception ec)
            {

            }
            return biljka;
        }


        #endregion

        #region LokalniNazivBiljke

        public static void sacuvajLokalniNazivBiljke(LokalniNazivBiljkeBasic biljka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                LokalniNazivBiljke lnb = new LokalniNazivBiljke();
                Biljka b = s.Load<Biljka>(biljka.biljka.BiljkaId);
                lnb.id.Id_biljkeFK = b;
                lnb.id.Lokalni_naziv = biljka.LokalniNaziv;
                s.Save(lnb);
                s.Flush();
                s.Close();
                
            }
            catch(Exception ec)
            {

            }
        }
        public static void obrisiLokalniNazivBiljke(LokalniNazivBiljkeBasic biljka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from LokalniNazivBiljke as l where l.id.Lokalni_naziv =?");
                q.SetParameter(0, biljka.LokalniNaziv);
                LokalniNazivBiljke lnb = q.UniqueResult<LokalniNazivBiljke>();

                s.Delete(lnb);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void izmeniLokalniNazivBiljke(LokalniNazivBiljkeBasic biljka,String staroIme)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from LokalniNazivBiljke as l where l.id.Lokalni_naziv =?");
                q.SetParameter(0, staroIme);
                LokalniNazivBiljke lnb = q.UniqueResult<LokalniNazivBiljke>();
                s.Delete(lnb);
                s.Flush();
                s.Close();

                ISession s1 = DataLayer.GetSession();

                LokalniNazivBiljke lnbn = new LokalniNazivBiljke();

                Biljka b = s1.Load<Biljka>(biljka.biljka.BiljkaId);
                lnbn.id.Id_biljkeFK = b;
                lnbn.id.Lokalni_naziv = biljka.LokalniNaziv;

                s1.Save(lnbn);

                s1.Flush();
                s1.Close();

            }
            catch (Exception ec)
            {

            }
        }

        #endregion

        #region ZasticenaBiljka
        public static List<ZasticenaBiljkaBasic> GetZasticenaBiljkaInfos()
        {
            List<ZasticenaBiljkaBasic> zasticeneBiljke = new List<ZasticenaBiljkaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka");
                IList<Biljka> biljke = q.List<Biljka>() ;
                foreach (Biljka b in biljke)
                {
                    if (NHibernateUtil.GetClass(b) == typeof(ZasticenaBiljka))
                    {
                        ZasticenaBiljka b1 = (ZasticenaBiljka)b;
                        zasticeneBiljke.Add(new ZasticenaBiljkaBasic(b.Id_biljke,b.Latinski_naziv,b1.Broj_odluke,b1.Datum_pocetka));
                    }
                }
                s.Close();
            }
            catch(Exception ec)
            {

            }
            return zasticeneBiljke;
        }

        public static void ZastitiBiljku(ZasticenaBiljkaBasic zbb)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "INSERT INTO ZASTICENA_BILJKA VALUES(?,?,?) ";
                int id = zbb.BiljkaId;
                int brOdluke = zbb.Broj_odluke;
                DateTime DatumPocetka = zbb.Datum_pocetka;
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, id);
                q.SetInt32(1, brOdluke);
                q.SetDateTime(2,DatumPocetka);
                q.ExecuteUpdate();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }

        public static void obrisiZastituBiljke(BiljkaBasic biljka)
        {
            try
            {
                
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM ZASTICENA_BILJKA WHERE ID_BILJKE = ? ";
                int id = biljka.BiljkaId;
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, id);
                q.ExecuteUpdate();
               
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void DodajZasticenuBiljku(ZasticenaBiljkaBasic biljka, OblastBasic oblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblast.OblastId);
                IList<Oblast> oblasti = new List<Oblast>();
                oblasti.Add(o);
                ZasticenaBiljka z = new ZasticenaBiljka();
                z.Latinski_naziv = biljka.LatinskiNaziv;
                z.Broj_odluke = biljka.Broj_odluke;
                z.Datum_pocetka = DateTime.Now;
                z.Oblasti = oblasti;
                s.Save(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static void ObrisiZasticenuBiljku(ZasticenaBiljkaBasic biljka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka as b where b.Id_biljke =?");
                q.SetParameter(0, biljka.BiljkaId);
                Biljka b = q.UniqueResult<Biljka>();
                s.Delete(b);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        #endregion

        #region Biljka
        public static void DodajBiljku(BiljkaBasic biljka, OblastBasic oblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblast.OblastId);
                IList<Oblast> oblasti = new List<Oblast>();
                oblasti.Add(o);
                Biljka z = new Biljka();
                z.Latinski_naziv = biljka.LatinskiNaziv;
                z.Oblasti = oblasti;
                s.Save(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void ObrisiBiljku(BiljkaBasic biljka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka as b where b.Id_biljke =?");
                q.SetParameter(0, biljka.BiljkaId);
                Biljka b = q.UniqueResult<Biljka>();
                s.Delete(b);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static void IzmeniLatinskiNaziv(int id, String latinskiNaziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b = s.Load<Biljka>(id);
                b.Latinski_naziv = latinskiNaziv;
                s.Update(b);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void DodajOblastGdeBiljkaRaste(BiljkaBasic biljka,int idOblasti)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast ob = s.Load<Oblast>(idOblasti);
                Biljka bi = s.Load<Biljka>(biljka.BiljkaId);
                bi.Oblasti.Add(ob);
                s.Update(bi);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static void ObrisiOblastGdeBiljkaRaste(BiljkaBasic biljka, int idOblasti)
        {
            IList<Oblast> oblasti = new List<Oblast>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast ob = s.Load<Oblast>(idOblasti);
                Biljka bi = s.Load<Biljka>(biljka.BiljkaId);
                foreach(Oblast oo in bi.Oblasti)
                {
                    if(oo.Ime != ob.Ime)
                    {
                        oblasti.Add(oo);
                    }
                }
                bi.Oblasti = oblasti;
                s.Update(bi);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        #endregion

        #region Radnik

        public static List<RadnikBasic> GetRadnikInfos()
        {
            List<RadnikBasic> radnikInfos = new List<RadnikBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Radnik");
                IList<Radnik> radnici = q.List<Radnik>();
               
                foreach (Radnik r in radnici)
                {
                    OblastBasic o = new OblastBasic(r.pripadaOblasti.Id_oblasti, r.pripadaOblasti.Ime, r.pripadaOblasti.Povrsina);
                    if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                    {
                        Volonter v1 = (Volonter)r;
                        radnikInfos.Add(new VolonterBasic(r.Id_radnika,r.Maticni_br,r.Ime,r.Prezime,r.Adresa,"Volonter",o));
                    }
                    else
                    {
                        // radnikInfos.Add(new RadnikBasic(r.Id_radnika, r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen", o));
                        StalnoZaposlen r1 = (StalnoZaposlen)r;
                        radnikInfos.Add(new StalnoZaposljenBasic(r.Id_radnika,
                            r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen",
                            r1.Broj_radne_knjizice, r1.Broj_licne_karte, r1.Mesto_izdavanja_lk, o));
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {

            }
            return radnikInfos;
            
        }

        public static List<RadnikBasic> GetRadnikeOblasti(OblastBasic oblast)
        {
            List<RadnikBasic> radnikInfos = new List<RadnikBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblast.OblastId);
                OblastBasic ob = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach (Radnik r in o.Radnici) {
                    if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                    {
                        Volonter v1 = (Volonter)r;
                        radnikInfos.Add(new VolonterBasic(r.Id_radnika, r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Volonter", ob));
                    }
                    else
                    {
                        StalnoZaposlen r1 = (StalnoZaposlen)r;
                        radnikInfos.Add(new StalnoZaposljenBasic(r.Id_radnika,
                            r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen",
                            r1.Broj_radne_knjizice, r1.Broj_licne_karte, r1.Mesto_izdavanja_lk, ob));
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {

            }
            return radnikInfos;

        }

        public static void DodajVolontera(VolonterBasic v)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(v.oblast.OblastId);
                Volonter volonter = new Volonter()
                {
                    Ime = v.Ime,
                    Prezime = v.Prezime,
                    Maticni_br = v.MaticniBroj,
                    Adresa = v.Adresa,
                    pripadaOblasti = oblast
                };
                s.Save(volonter);
                s.Flush();
                s.Close();

            }
            catch(Exception ec)
            {

            }
        }

        public static void DodajStalnoZaposljenog(StalnoZaposljenBasic szb)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(szb.oblast.OblastId);
                StalnoZaposlen stalnoZaposljen = new StalnoZaposlen()
                {
                    Ime = szb.Ime,
                    Prezime = szb.Prezime,
                    Maticni_br = szb.MaticniBroj,
                    Adresa = szb.Adresa,
                    pripadaOblasti = oblast,
                    Broj_radne_knjizice = szb.BrojRadneKnjizice,
                    Broj_licne_karte = szb.BrojLicneKarte,
                    Mesto_izdavanja_lk = szb.MestoIzdavanjaLK
                };
                s.Save(stalnoZaposljen);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }

        public static bool ObrisiRadnika(int id)
        {
            bool test;
            try
            {
                ISession s = DataLayer.GetSession();
                Radnik radnik = s.Load<Radnik>(id);

                s.Delete(radnik);
                s.Flush();
                s.Close();
                

            }
            catch (Exception ec)
            {
                test = false;
            }
            test = true;
            return test;
        }

        public static void IzmeniRadnika(RadnikBasic rad)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Radnik as o where o.Id_radnika = ?");
                q.SetInt32(0,rad.Id_radnika);
                Radnik r = q.UniqueResult<Radnik>();
                Oblast o = s.Load<Oblast>(rad.oblast.OblastId);
                if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                {
                        Volonter v = (Volonter)r;
                        v.Ime = rad.Ime;
                        v.Prezime = rad.Prezime;
                        v.Maticni_br = rad.MaticniBroj;
                        v.Adresa = rad.Adresa;
                        v.pripadaOblasti = o;
                        s.SaveOrUpdate(v);
                        s.Flush();
                        s.Close();
                }
                else if (NHibernateUtil.GetClass(r) == typeof(StalnoZaposlen))
                {
                    
                        StalnoZaposlen sp = (StalnoZaposlen)r;
                        StalnoZaposljenBasic spr = (StalnoZaposljenBasic)rad;
                        sp.Ime = rad.Ime;
                        sp.Prezime = rad.Prezime;
                        sp.Maticni_br = rad.MaticniBroj;
                        sp.Adresa = rad.Adresa;
                        sp.pripadaOblasti = o;
                        sp.Mesto_izdavanja_lk = spr.MestoIzdavanjaLK;
                        sp.Broj_radne_knjizice = spr.BrojRadneKnjizice;
                        sp.Broj_licne_karte = spr.BrojLicneKarte;

                        s.SaveOrUpdate(sp);
                        s.Flush();
                        s.Close();
                   
                }
            }
            catch (Exception ec)
            {

            }
        }

        #endregion

        #region Zivotinje
        
        public static List<ZivotinjaBasic> getZivotinjeInfo()
        {
            List<ZivotinjaBasic> zivotinje = new List<ZivotinjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja");
                IList<Zivotinja> ziv = q.List<Zivotinja>();

                foreach (Zivotinja z in ziv)
                {
                    if (NHibernateUtil.GetClass(z) == typeof(Ptice_selice))
                    {
                        Ptice_selice ps = (Ptice_selice)z;
                        PticaSelicaBasic psb = new PticaSelicaBasic(z.Id_zivotinje, z.Serijski_broj_prstena, z.Lokalni_naziv, z.Latinski_naziv, "Da");
                        foreach (Oblast o in z.Oblasti)
                        {
                            OblastBasic o1 = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                            psb.pripadaOblasti.Add(o1);
                        }
                        foreach(PticeSeliceZivotinje psz in ps.zemlje)
                        {
                            
                            PticaSelicaZemljeBasic pszb = new PticaSelicaZemljeBasic(psb, psz.id.Zemlje);
                            psb.zemlje.Add(pszb);
                        }
                        zivotinje.Add(psb);
                    }
                    else
                    {
                        ZivotinjaBasic z1 = new ZivotinjaBasic(z.Id_zivotinje, z.Serijski_broj_prstena, z.Lokalni_naziv, z.Latinski_naziv, "Ne");
                        foreach (Oblast o in z.Oblasti)
                        {
                            OblastBasic o1 = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                            z1.pripadaOblasti.Add(o1);
                        }
                        zivotinje.Add(z1);
                    }
                }
                s.Close();
                return zivotinje;
            }
            catch(Exception ec)
            {

            }
            return zivotinje;
        }

        public static void DodajZemljuPticiSelici(PticaSelicaZemljeBasic zemlja)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z = s.Load<Zivotinja>(zemlja.zivotinja.IdZivotinje);
                PticeSeliceZivotinje p = new PticeSeliceZivotinje();
                p.id.Id_zivotinjeFK = z;
                p.id.Zemlje = zemlja.zemlja;
                s.Save(p);
                s.Flush();
                s.Close();
             
            }
            catch(Exception ec)
            {

            }
        }

        public static void ObrisiZemljuPticiSelici(String zemlja)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from PticeSeliceZivotinje as l where l.id.Zemlje =?");
                q.SetParameter(0, zemlja);
                PticeSeliceZivotinje lnb = q.UniqueResult<PticeSeliceZivotinje>();
                s.Delete(lnb);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void DodajZivotinju(ZivotinjaBasic z, OblastBasic o)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(o.OblastId);
                IList<Oblast> oblasti = new List<Oblast>();
                oblasti.Add(oblast);

                Zivotinja zivotinja = new Zivotinja();
                zivotinja.Latinski_naziv = z.LatinskiNaziv;
                zivotinja.Lokalni_naziv = z.LokalniNaziv;
                zivotinja.Serijski_broj_prstena = z.SerijskiBrojPrstena;
                zivotinja.Oblasti = oblasti;
          
                s.Save(zivotinja);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }

        public static bool DodajPticuSelicu(PticaSelicaBasic z, OblastBasic o)
        {
            bool t;
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(o.OblastId);
                IList<Oblast> oblasti = new List<Oblast>();
                oblasti.Add(oblast);

                Ptice_selice zivotinja = new Ptice_selice();
                zivotinja.Latinski_naziv = z.LatinskiNaziv;
                zivotinja.Lokalni_naziv = z.LokalniNaziv;
                zivotinja.Serijski_broj_prstena = z.SerijskiBrojPrstena;
                zivotinja.Oblasti = oblasti;

                s.Save(zivotinja);
                s.Flush();
                s.Close();
                t = true;
            }
            catch (Exception ec)
            {
                t = false;
            }
            return t;
        }

        public static PticaSelicaBasic GetPticaSelica(String lokalniNaziv)
        {
            PticaSelicaBasic ptica = new PticaSelicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja as l where l.Lokalni_naziv =?");
                q.SetParameter(0, lokalniNaziv);
                Zivotinja z = q.UniqueResult<Zivotinja>();
                ptica.IdZivotinje = z.Id_zivotinje;
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return ptica;
        }

        public static bool ObrisiZivotinju(int idZivotinje)
        {
            bool test;
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja zivotinja = s.Load<Zivotinja>(idZivotinje);

                s.Delete(zivotinja);
                s.Flush();
                s.Close();
                test = true;

            }
            catch (Exception ec)
            {
                test = false;
            }
            
            return test;

        }

        public static void IzmeniZivotinju(ZivotinjaBasic zivotinja)
        {
            IList<Oblast> oblasti = new List<Oblast>();
            
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z = s.Load<Zivotinja>(zivotinja.IdZivotinje);
                z.Serijski_broj_prstena = zivotinja.SerijskiBrojPrstena;
                z.Lokalni_naziv = zivotinja.LokalniNaziv;
                z.Latinski_naziv = zivotinja.LatinskiNaziv;

                foreach(OblastBasic o in zivotinja.pripadaOblasti)
                {
                    Oblast o1 = s.Load<Oblast>(o.OblastId);
                    oblasti.Add(o1);
                }
                z.Oblasti = oblasti;

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static List<ZivotinjaBasic> getZivotinjeOblasti(OblastBasic o)
        {
            List<ZivotinjaBasic> zivotinje = new List<ZivotinjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(o.OblastId);
                foreach(Zivotinja z in oblast.Zivotinje)
                {
                    zivotinje.Add(new ZivotinjaBasic(z.Id_zivotinje, z.Serijski_broj_prstena, z.Lokalni_naziv, z.Latinski_naziv, ""));
                }
                s.Close();
            }
            catch(Exception ec)
            {

            }
            return zivotinje;
        }
        #endregion

        #region Pripada

        public static void ObrisiVezuPripadaZivotinja(int IdZivotinje)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM PRIPADA WHERE ID_ZIVOTINJEFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, IdZivotinje);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static void ObrisiVezuPripadaOblast(int IdOblasti)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM PRIPADA WHERE ID_OBLASTIFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, IdOblasti);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        #endregion

        #region Primecena_je
        public static void ObrisiVezuPrimecenaJeZivotinja(int IdZivotinje)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM PRIMECENA_JE WHERE ID_ZIVOTINJEFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, IdZivotinje);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void ObrisiVezuPrimecenaJeHraniliste(int IdHranilista)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM PRIMECENA_JE WHERE ID_HRANILISTAFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, IdHranilista);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<PrimecenaJeBasic> GetPrimeceneZivotinje(HranilisteBasic hraniliste)
        {
            List<PrimecenaJeBasic> zivotinje = new List<PrimecenaJeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Hraniliste h = s.Load<Hraniliste>(hraniliste.IdHranilista);
                HranilisteBasic h1 = new HranilisteBasic(h.Id, h.Pocetni_datum, h.Krajnji_datum,new OblastBasic( h.PripadaOblasti.Id_oblasti,h.PripadaOblasti.Ime,h.PripadaOblasti.Povrsina));
                foreach(Primecena_je pj in h.PrimecenaJeZivotinja)
                {
                    PrimecenaJeBasic newP = new PrimecenaJeBasic(new ZivotinjaBasic(pj.Id.Id_zivotinje.Id_zivotinje, pj.Id.Id_zivotinje.Serijski_broj_prstena, pj.Id.Id_zivotinje.Lokalni_naziv, pj.Id.Id_zivotinje.Latinski_naziv, ""), h1, pj.Datum_vidjenja);
                    zivotinje.Add(newP);
                }
                s.Close();
            }
            catch (Exception ec)
            {

            }
            return zivotinje;

        }

        public static void DodajNovuZivotinjuUHraniliste(PrimecenaJeBasic pjb)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z = s.Load<Zivotinja>(pjb.zivotinja.IdZivotinje);
                Hraniliste h = s.Load<Hraniliste>(pjb.hraniliste.IdHranilista);
                Primecena_je pj = new Primecena_je();
                pj.Id.Id_zivotinje = z;
                pj.Id.Id_hranilista = h;
                pj.Datum_vidjenja = pjb.DatumVidjenja;
                s.Save(pj);
                s.Flush(); 
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

       


        #endregion

        #region Raste

        public static void ObrisiVezuRasteBiljka(int idBiljke)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM RASTE WHERE ID_BILJKEFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, idBiljke);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void ObrisiVezuRasteOblast(int idOblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String sql = "DELETE FROM RASTE WHERE ID_OBLASTIFK = ? ";
                ISQLQuery q = s.CreateSQLQuery(sql);
                q.SetInt32(0, idOblast);
                q.ExecuteUpdate();
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        #endregion

        #region Hraniliste
        public static List<HranilisteBasic> GetHranilistaOblasti(OblastBasic oblast)
        {
            List<HranilisteBasic> hranilista = new List<HranilisteBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblast.OblastId);
                OblastBasic ob = new OblastBasic(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach(Hraniliste h in o.Hranilista)
                {
                    HranilisteBasic h1 = new HranilisteBasic(h.Id, h.Pocetni_datum, h.Krajnji_datum, ob);
                    h1.brojZivotinja = h.PrimecenaJeZivotinja.Count;
                    hranilista.Add(h1);

                }
                s.Close();
            }
            catch (Exception ec)
            {

            }
            return hranilista;

        }


        public static void DodajHraniliste(HranilisteBasic h)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(h.pripadaOblasti.OblastId);
                Hraniliste hraniliste = new Hraniliste();
                hraniliste.Pocetni_datum = h.DatumPocetka;
                hraniliste.Krajnji_datum = h.DatumKraja;
                hraniliste.PripadaOblasti = o;
                s.Save(hraniliste);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {

            }
        }

        public static void IzmeniHraniliste(HranilisteBasic h)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Hraniliste hraniliste = s.Load<Hraniliste>(h.IdHranilista);
                hraniliste.Pocetni_datum = h.DatumPocetka;
                hraniliste.Krajnji_datum = h.DatumKraja;
                s.Update(hraniliste);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }


        public static void ObrisiHraniliste(int idHranilista)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Hraniliste h = s.Load<Hraniliste>(idHranilista);

                s.Delete(h);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        #endregion
    }
}
