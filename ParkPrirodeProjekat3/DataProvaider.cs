using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirodeProjekat3.Entiteti;
using ParkPrirodeProjekat3.DTOs;
using NHibernate.Linq;
using NHibernate;

namespace ParkPrirodeProjekat3
{
    public class DataProvaider
    {
        #region Oblast
       
        public static List<OblastView> GetOblasti()
        {
            List<OblastView> obInfos = new List<OblastView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Oblast");
                IEnumerable<Oblast> Oblasti = q.Enumerable<Oblast>();
                foreach (Oblast o in Oblasti)
                {
                    if (NHibernateUtil.GetClass(o) == typeof(OblastMonitoring))
                    {
                        var ob = new MonitoringView(o.Id_oblasti, o.Ime, o.Povrsina,"Monitoring");
                        ob.NazivSela = o.Naziv_sela.Select(p => new NazivSelaOblastView(p)).ToList();
                        ob.Biljke = o.Biljke.Select(p => new BiljkaView(p)).ToList();
                        ob.Zivotinje = o.Zivotinje.Select(p => new ZivotinjaView(p)).ToList();
                        ob.Hranilista = o.Hranilista.Select(p => new HranilisteView(p)).ToList();
                        ob.Radnici = o.Radnici.Select(p=> new RadnikView(p)).ToList();
                        obInfos.Add(ob);
                    }
                    else if(NHibernateUtil.GetClass(o) == typeof(OblastStalnaZastita))
                    {
                        var ob = new StalnaZastitaView(o.Id_oblasti, o.Ime, o.Povrsina,"Stalna zastita");
                        ob.NazivSela = o.Naziv_sela.Select(p => new NazivSelaOblastView(p)).ToList();
                        ob.Biljke = o.Biljke.Select(p => new BiljkaView(p)).ToList();
                        ob.Zivotinje = o.Zivotinje.Select(p => new ZivotinjaView(p)).ToList();
                        ob.Hranilista = o.Hranilista.Select(p => new HranilisteView(p)).ToList();
                         ob.Radnici = o.Radnici.Select(p=> new RadnikView(p)).ToList();
                        obInfos.Add(ob);
                    }
                    else if (NHibernateUtil.GetClass(o) == typeof(OblastPovremenaZastita))
                    {
                         var ob = new PovremenaIntervencijaView(o.Id_oblasti, o.Ime, o.Povrsina,"Povremena intervencija");
                        ob.NazivSela = o.Naziv_sela.Select(p => new NazivSelaOblastView(p)).ToList();
                        ob.Biljke = o.Biljke.Select(p => new BiljkaView(p)).ToList();
                        ob.Zivotinje = o.Zivotinje.Select(p => new ZivotinjaView(p)).ToList();
                        ob.Hranilista = o.Hranilista.Select(p => new HranilisteView(p)).ToList();
                        ob.Radnici = o.Radnici.Select(p=> new RadnikView(p)).ToList();
                        obInfos.Add(ob);
                    }
                }

                s.Close();
            }
            catch (Exception)
            {

            }

            return obInfos;
        }

        public static List<ZivotinjaView> getZivotinje()
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try{
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja");
                IList<Zivotinja> ziv = q.List<Zivotinja>();

                foreach (Zivotinja z in ziv){
                    var zivotinja = new ZivotinjaView(z);
                    zivotinja.Hranilista = z.PrimecenaJeKodHranilista.Select(p => new PrimecenaJeView(p)).ToList();
                    zivotinje.Add(zivotinja);
                }
            }
            catch(Exception){

            }
            return zivotinje;
        }

        public static OblastView GetOblast(int oblastID)
        {
            OblastView oblast = new OblastView();
            try{
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblastID);
                if (NHibernateUtil.GetClass(o) == typeof(OblastMonitoring))
                {
                        oblast = new MonitoringView(o.Id_oblasti, o.Ime, o.Povrsina,"Monitoring"); 
                }
                else if(NHibernateUtil.GetClass(o) == typeof(OblastStalnaZastita))
                {
                    oblast = new StalnaZastitaView(o.Id_oblasti, o.Ime, o.Povrsina,"Stalna zastita");     
                }
                else if (NHibernateUtil.GetClass(o) == typeof(OblastPovremenaZastita))
                {
                    oblast = new PovremenaIntervencijaView(o.Id_oblasti, o.Ime, o.Povrsina,"Povremena intervencija");
                       
                }
            }
            catch(Exception){

            }
            return oblast;
        }

        public static List<BiljkaView> GetBiljkeOblasti(int oblastID)
        {
            List<BiljkaView> biljke = new List<BiljkaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblastID);
                foreach(Biljka b in o.Biljke ){
                    var biljka = new BiljkaView(b);
                    biljka.LokalniNazivi = b.LokalniNazivi.Select(p => new LokalniNazivBiljkeView(p)).ToList();
                    biljke.Add(biljka);
                }
            }
            catch(Exception){

            }
            return biljke;
        }

        public static void IzmeniZasticenuBiljku(ZasticenaBiljkaView z)
        {
            try{
                ISession s = DataLayer.GetSession();
                ZasticenaBiljka biljka = s.Load<ZasticenaBiljka>(z.BiljkaId);
                if(z.LatinskiNaziv != null){
                  biljka.Latinski_naziv = z.LatinskiNaziv;
                }
                if(z.Broj_odluke != 0){
                     biljka.Broj_odluke = z.Broj_odluke;
                }
                if(z.Datum_pocetka != null){
                      biljka.Datum_pocetka = z.Datum_pocetka;
                }
                s.SaveOrUpdate(biljka);
                s.Flush();
                s.Close();
            }
            catch(Exception){

            }
        }

        public static List<StalnaZastitaView> GetStalnoZasticeneOblasti(){
            List<StalnaZastitaView> obInfos = new List<StalnaZastitaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Oblast");
                IEnumerable<Oblast> Oblasti = q.Enumerable<Oblast>();
                foreach (Oblast o in Oblasti)
                {
                  if(NHibernateUtil.GetClass(o) == typeof(OblastStalnaZastita))
                    {
                        var ob = new StalnaZastitaView(o.Id_oblasti, o.Ime, o.Povrsina,"Stalna zastita");
                        ob.NazivSela = o.Naziv_sela.Select(p => new NazivSelaOblastView(p)).ToList();
                        ob.Biljke = o.Biljke.Select(p => new BiljkaView(p)).ToList();
                        ob.Zivotinje = o.Zivotinje.Select(p => new ZivotinjaView(p)).ToList();
                        ob.Hranilista = o.Hranilista.Select(p => new HranilisteView(p)).ToList();
                        ob.Radnici = o.Radnici.Select(p=> new RadnikView(p)).ToList();
                        obInfos.Add(ob);
                    }
                    
                }

                s.Close();
            }
            catch (Exception)
            {

            }
            return obInfos;
        }
        public static List<NazivSelaOblastView> GetNazivSela(int idOblasti)
        {
            List<NazivSelaOblastView> sela = new List<NazivSelaOblastView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(idOblasti);
                OblastView on = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach (NazivSelaOblast nso in o.Naziv_sela) {
                    sela.Add(new NazivSelaOblastView(on, nso.id.Naziv_sela));
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
            catch(Exception)
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
            catch (Exception)
            {
                test = false;
            }
            return test;
        }

        public static void DodajOblast(OblastView oblast)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                if(oblast.GetType() == typeof(MonitoringView))
                {
                    OblastMonitoring o = new OblastMonitoring();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
                else if (oblast.GetType() == typeof(PovremenaIntervencijaView))
                {
                    OblastPovremenaZastita o = new OblastPovremenaZastita();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
                else if (oblast.GetType() == typeof(StalnaZastitaView))
                {
                    OblastStalnaZastita o = new OblastStalnaZastita();
                    o.Ime = oblast.Ime;
                    o.Povrsina = oblast.Povrsina;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                }
            }
            catch(Exception)
            {

            }
        }

        public static void IzmeniOblast(OblastView oblast)
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
            catch (Exception)
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
            catch (Exception)
            {

            }
        }
        #endregion

        #region BiljkaForm
        public static List<BiljkaView> GetBiljkaInfos() {
            List<BiljkaView> biljkaInfos = new List<BiljkaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka");
                IEnumerable<Biljka> biljke = q.Enumerable<Biljka>();
                foreach (Biljka b in biljke)
                {
                    BiljkaView biljka = new BiljkaView();
                    if (NHibernateUtil.GetClass(b) == typeof(ZasticenaBiljka))
                    {
                        //biljkaInfos.Add(new BiljkaView(b.Id_biljke, b.Latinski_naziv, "Da"));
                        biljka = new BiljkaView(b.Id_biljke, b.Latinski_naziv, "Da");
                    }
                    else
                    {
                       // biljkaInfos.Add(new BiljkaView(b.Id_biljke, b.Latinski_naziv, "Ne"));
                       biljka = new BiljkaView(b.Id_biljke, b.Latinski_naziv, "Ne");
                    }
                    biljka.LokalniNazivi = b.LokalniNazivi.Select(p => new LokalniNazivBiljkeView(p)).ToList();
                    biljkaInfos.Add(biljka);
                }
                s.Close();
            }
            catch(Exception)
            {

            }
            return biljkaInfos;
        }

        public static BiljkaView GetBiljka(int id)
        {
            BiljkaView biljka = new BiljkaView();
            try
            {
                ISession s = DataLayer.GetSession();
                Biljka b = s.Load<Biljka>(id);
                
                biljka.BiljkaId = b.Id_biljke;
                biljka.LatinskiNaziv = b.Latinski_naziv;
                foreach(LokalniNazivBiljke lnb in b.LokalniNazivi)
                {
                    LokalniNazivBiljkeView lnbb = new LokalniNazivBiljkeView(lnb.id.Lokalni_naziv);
                    biljka.LokalniNazivi.Add(lnbb);
                }
                foreach (Oblast o in b.Oblasti) {
                    OblastView o1 = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                    biljka.PripadaOblasti.Add(o1);
                }
                s.Close();
               
            }
            catch(Exception)
            {

            }
            return biljka;
        }


        #endregion

        #region LokalniNazivBiljke

        public static void sacuvajLokalniNazivBiljke(LokalniNazivBiljkeView biljka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                LokalniNazivBiljke lnb = new LokalniNazivBiljke();
                Biljka b = s.Load<Biljka>(biljka.Biljka.BiljkaId);
                lnb.id.Id_biljkeFK = b;
                lnb.id.Lokalni_naziv = biljka.LokalniNaziv;
                s.Save(lnb);
                s.Flush();
                s.Close();
                
            }
            catch(Exception)
            {

            }
        }
        public static void obrisiLokalniNazivBiljke(LokalniNazivBiljkeView biljka)
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
            catch (Exception)
            {
                //handle exceptions
            }
        }

        public static void izmeniLokalniNazivBiljke(LokalniNazivBiljkeView biljka,String staroIme)
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

                Biljka b = s1.Load<Biljka>(biljka.Biljka.BiljkaId);
                lnbn.id.Id_biljkeFK = b;
                lnbn.id.Lokalni_naziv = biljka.LokalniNaziv;

                s1.Save(lnbn);

                s1.Flush();
                s1.Close();

            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region ZasticenaBiljka
        public static List<ZasticenaBiljkaView> GetZasticenaBiljkaInfos()
        {
            List<ZasticenaBiljkaView> zasticeneBiljke = new List<ZasticenaBiljkaView>();
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
                        zasticeneBiljke.Add(new ZasticenaBiljkaView(b.Id_biljke,b.Latinski_naziv,"Da",b1.Broj_odluke,b1.Datum_pocetka));
                    }
                }
                s.Close();
            }
            catch(Exception)
            {

            }
            return zasticeneBiljke;
        }

        public static void ZastitiBiljku(ZasticenaBiljkaView zbb)
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
            catch (Exception)
            {

            }
        }

        public static void obrisiZastituBiljke(BiljkaView biljka)
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
            catch (Exception)
            {
                //handle exceptions
            }
        }

        public static void DodajZasticenuBiljku(ZasticenaBiljkaView biljka, OblastView oblast)
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
            catch (Exception)
            {

            }
        }
        public static void ObrisiZasticenuBiljku(ZasticenaBiljkaView biljka)
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
            catch (Exception)
            {

            }
        }

        #endregion

        #region Biljka
        public static void DodajBiljku(BiljkaView biljka, OblastView oblast)
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
            catch (Exception)
            {

            }
        }

        public static void ObrisiBiljku(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Biljka as b where b.Id_biljke =?");
                q.SetParameter(0, id);
                Biljka b = q.UniqueResult<Biljka>();
                s.Delete(b);
                s.Flush();
                s.Close();
            }
            catch(Exception)
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
            catch (Exception)
            {

            }
        }

        public static void DodajOblastGdeBiljkaRaste(BiljkaView biljka,int idOblasti)
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
            catch(Exception)
            {

            }
        }

        public static void ObrisiOblastGdeBiljkaRaste(BiljkaView biljka, int idOblasti)
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
            catch (Exception)
            {

            }
        }
        #endregion

        #region Radnik

        public static List<RadnikView> GetRadnikInfos()
        {
            List<RadnikView> radnikInfos = new List<RadnikView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Radnik");
                IList<Radnik> radnici = q.List<Radnik>();
               
                foreach (Radnik r in radnici)
                {
                    OblastView o = new OblastView(r.pripadaOblasti.Id_oblasti, r.pripadaOblasti.Ime, r.pripadaOblasti.Povrsina);
                    if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                    {
                        Volonter v1 = (Volonter)r;
                        radnikInfos.Add(new VolonterView(r.Id_radnika,r.Maticni_br,r.Ime,r.Prezime,r.Adresa,"Volonter",o));
                    }
                    else
                    {
                        // radnikInfos.Add(new RadnikBasic(r.Id_radnika, r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen", o));
                        StalnoZaposlen r1 = (StalnoZaposlen)r;
                        radnikInfos.Add(new StalnoZaposljenView(r.Id_radnika,
                            r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen",
                            r1.Broj_radne_knjizice, r1.Broj_licne_karte, r1.Mesto_izdavanja_lk, o));
                    }
                }
                s.Close();
            }
            catch (Exception)
            {

            }
            return radnikInfos;
            
        }

        public static List<RadnikView> GetRadnikeOblasti(int oblastId)
        {
            List<RadnikView> radnikInfos = new List<RadnikView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(oblastId);
                OblastView ob = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach (Radnik r in o.Radnici) {
                    if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                    {
                        Volonter v1 = (Volonter)r;
                        radnikInfos.Add(new VolonterView(r.Id_radnika, r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Volonter", ob));
                    }
                    else
                    {
                        StalnoZaposlen r1 = (StalnoZaposlen)r;
                        radnikInfos.Add(new StalnoZaposljenView(r.Id_radnika,
                            r.Maticni_br, r.Ime, r.Prezime, r.Adresa, "Stalno zaposljen",
                            r1.Broj_radne_knjizice, r1.Broj_licne_karte, r1.Mesto_izdavanja_lk, ob));
                    }
                }
                s.Close();
            }
            catch (Exception)
            {

            }
            return radnikInfos;

        }

        public static void DodajVolontera(VolonterView v,int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(id);
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
            catch(Exception)
            {

            }
        }

        public static void DodajStalnoZaposljenog(StalnoZaposljenView szb, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(id);
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
            catch (Exception)
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
            catch (Exception)
            {
                test = false;
            }
            test = true;
            return test;
        }

        public static void IzmeniRadnika(RadnikView rad)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Radnik as o where o.Id_radnika = ?");
                q.SetInt32(0,rad.Id_radnika);
                Radnik r = q.UniqueResult<Radnik>();
                Oblast o = s.Load<Oblast>(rad.Oblast.OblastId);
                if (NHibernateUtil.GetClass(r) == typeof(Volonter))
                {
                        Volonter v = (Volonter)r;
                        if(rad.Ime != null){ v.Ime = rad.Ime; }
                        if(rad.Prezime != null){ v.Prezime = rad.Prezime; }
                        if(rad.MaticniBroj != 0) {  v.Maticni_br = rad.MaticniBroj; }
                        if(rad.Adresa != null) {   v.Adresa = rad.Adresa; }
                      
                        v.pripadaOblasti = o;
                        s.SaveOrUpdate(v);
                        s.Flush();
                        s.Close();
                }
                else if (NHibernateUtil.GetClass(r) == typeof(StalnoZaposlen))
                {
                    
                        StalnoZaposlen sp = (StalnoZaposlen)r;
                        StalnoZaposljenView spr = (StalnoZaposljenView)rad;
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
            catch (Exception)
            {

            }
        }

        #endregion

        #region Zivotinje
        
        public static List<ZivotinjaView> getZivotinjeInfo()
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
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
                        PticaSelicaView psb = new PticaSelicaView(z.Id_zivotinje, z.Serijski_broj_prstena, z.Lokalni_naziv, z.Latinski_naziv, "Da");
                        foreach (Oblast o in z.Oblasti)
                        {
                            OblastView o1 = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                            psb.pripadaOblasti.Add(o1);
                        }
                        foreach(PticeSeliceZivotinje psz in ps.zemlje)
                        {
                            
                            PticaSelicaZemljeView pszb = new PticaSelicaZemljeView(psb, psz.id.Zemlje);
                            psb.zemlje.Add(pszb);
                        }
                        zivotinje.Add(psb);
                    }
                    else
                    {
                        ZivotinjaView z1 = new ZivotinjaView(z.Id_zivotinje, z.Serijski_broj_prstena, z.Lokalni_naziv, z.Latinski_naziv, "Ne");
                        foreach (Oblast o in z.Oblasti)
                        {
                            OblastView o1 = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                            z1.pripadaOblasti.Add(o1);
                        }
                        zivotinje.Add(z1);
                    }
                }
                s.Close();
                return zivotinje;
            }
            catch(Exception)
            {

            }
            return zivotinje;
        }

        public static void DodajZemljuPticiSelici(PticaSelicaZemljeView zemlja)
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
            catch(Exception)
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
            catch (Exception)
            {
                //handle exceptions
            }
        }

        public static void DodajZivotinju(ZivotinjaView z, OblastView o)
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
            catch (Exception)
            {

            }
        }

        public static bool DodajPticuSelicu(PticaSelicaView z, OblastView o)
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
            catch (Exception)
            {
                t = false;
            }
            return t;
        }

        public static PticaSelicaView GetPticaSelica(String lokalniNaziv)
        {
            PticaSelicaView ptica = new PticaSelicaView();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja as l where l.Lokalni_naziv =?");
                q.SetParameter(0, lokalniNaziv);
                Zivotinja z = q.UniqueResult<Zivotinja>();
                ptica.IdZivotinje = z.Id_zivotinje;
                s.Close();

            }
            catch (Exception)
            {
                //handle exceptions
            }
            return ptica;
        }

        public static List<PticaSelicaView> GetPticeSelice()
        {
            List<PticaSelicaView> ptice = new List<PticaSelicaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Zivotinja");
                IList<Zivotinja> ziv = q.List<Zivotinja>();

                foreach (Zivotinja z in ziv)
                {
                    if (NHibernateUtil.GetClass(z) == typeof(Ptice_selice))
                    {
                        Ptice_selice p = (Ptice_selice)z;
                        var ptica = new PticaSelicaView(p);
                        ptica.zemlje = p.zemlje.Select(p => new PticaSelicaZemljeView(p)).ToList();
                        ptice.Add(ptica);
                    }
                    
                }
                s.Close();
               
            }
            catch(Exception){

            }
            return ptice;
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
            catch (Exception)
            {
                test = false;
            }
            
            return test;

        }

        public static void IzmeniZivotinju(ZivotinjaView zivotinja)
        {
            IList<Oblast> oblasti = new List<Oblast>();
            
            try
            {
                ISession s = DataLayer.GetSession();
                Zivotinja z = s.Load<Zivotinja>(zivotinja.IdZivotinje);
                if(zivotinja.SerijskiBrojPrstena != 0){ z.Serijski_broj_prstena = zivotinja.SerijskiBrojPrstena; }
                if(zivotinja.LokalniNaziv != null) {  z.Lokalni_naziv = zivotinja.LokalniNaziv; }
                if(zivotinja.LatinskiNaziv != null) {  z.Latinski_naziv = zivotinja.LatinskiNaziv; }
               
               

                foreach(OblastView o in zivotinja.pripadaOblasti)
                {
                    Oblast o1 = s.Load<Oblast>(o.OblastId);
                    oblasti.Add(o1);
                }
                z.Oblasti = oblasti;

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch(Exception)
            {

            }
        }

        public static List<ZivotinjaView> getZivotinjeOblasti(int id)
        {
            List<ZivotinjaView> zivotinje = new List<ZivotinjaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast oblast = s.Load<Oblast>(id);
                foreach(Zivotinja z in oblast.Zivotinje)
                {
                    zivotinje.Add(new ZivotinjaView(z));
                }
                s.Close();
            }
            catch(Exception)
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
            catch(Exception)
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
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
            {

            }
        }

        public static List<PrimecenaJeView> GetPrimeceneZivotinje(HranilisteView hraniliste)
        {
            List<PrimecenaJeView> zivotinje = new List<PrimecenaJeView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Hraniliste h = s.Load<Hraniliste>(hraniliste.IdHranilista);
                HranilisteView h1 = new HranilisteView(h.Id, h.Pocetni_datum, h.Krajnji_datum,new OblastView( h.PripadaOblasti.Id_oblasti,h.PripadaOblasti.Ime,h.PripadaOblasti.Povrsina));
                foreach(Primecena_je pj in h.PrimecenaJeZivotinja)
                {
                    PrimecenaJeView newP = new PrimecenaJeView(new ZivotinjaView(pj.Id.Id_zivotinje.Id_zivotinje, pj.Id.Id_zivotinje.Serijski_broj_prstena, pj.Id.Id_zivotinje.Lokalni_naziv, pj.Id.Id_zivotinje.Latinski_naziv, ""), h1, pj.Datum_vidjenja);
                    zivotinje.Add(newP);
                }
                s.Close();
            }
            catch (Exception)
            {

            }
            return zivotinje;

        }

        public static void DodajNovuZivotinjuUHraniliste(PrimecenaJeView pjb)
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
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
            {

            }
        }
        #endregion

        #region Hraniliste
        public static List<HranilisteView> GetHranilistaOblasti(int id)
        {
            List<HranilisteView> hranilista = new List<HranilisteView>();
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(id);
                OblastView ob = new OblastView(o.Id_oblasti, o.Ime, o.Povrsina);
                foreach(Hraniliste h in o.Hranilista)
                {
                    HranilisteView h1 = new HranilisteView(h.Id, h.Pocetni_datum, h.Krajnji_datum, ob);
                    h1.zivotinje = h.PrimecenaJeZivotinja.Select(p => new PrimecenaJeView(p)).ToList();
                    h1.brojZivotinja = h.PrimecenaJeZivotinja.Count;
                    hranilista.Add(h1);

                }
                s.Close();
            }
            catch (Exception)
            {

            }
            return hranilista;

        }


        public static void DodajHraniliste(HranilisteView h,OblastView ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oblast o = s.Load<Oblast>(ob.OblastId);
                Hraniliste hraniliste = new Hraniliste();
                hraniliste.Pocetni_datum = h.DatumPocetka;
                hraniliste.Krajnji_datum = h.DatumKraja;
                hraniliste.PripadaOblasti = o;
                s.Save(hraniliste);
                s.Flush();
                s.Close();
            }
            catch(Exception)
            {

            }
        }

        public static void IzmeniHraniliste(HranilisteView h)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Hraniliste hraniliste = s.Load<Hraniliste>(h.IdHranilista);
                if(h.DatumPocetka != null) {   hraniliste.Pocetni_datum = h.DatumPocetka; }
                if(h.DatumKraja != null) { hraniliste.Krajnji_datum = h.DatumKraja; }
               
                s.Update(hraniliste);
                s.Flush();
                s.Close();
            }
            catch (Exception)
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
            catch (Exception)
            {

            }
        }
        #endregion
    }
}
