using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode
{
    #region Oblast
    public class OblastPregled
    {
        public int OblastId { get; set; }
        public String OblastIme { get; set; }
        public float OblastPovrsina { get; set; }
        public int BrojSela { get; set; }
        public int BrojZivotinja { get; set; }
        public int BrojBiljaka { get; set; }
        public int BrojRadnika { get; set; }
        public int BrojHranilista { get; set; }

        public OblastPregled(int oId, String ime, float pov, int bs, int bz, int bb, int br, int bh)
        {
            this.OblastId = oId;
            this.OblastIme = ime;
            this.OblastPovrsina = pov;
            this.BrojSela = bs;
            this.BrojZivotinja = bz;
            this.BrojBiljaka = bb;
            this.BrojRadnika = br;
            this.BrojHranilista = bh;
        }
    }

    public class OblastMonitoringPogled: OblastPregled
    {
        public String TipZastite { get; set; }
        public OblastMonitoringPogled(int oId, String ime, float pov, int bs, int bz, int bb, int br, int bh,String Tip): base(oId, ime, pov, bs, bz, bb, br, bh)
        {
            this.TipZastite = Tip;
        }
    }

    public class OblastPovremenaIntervencijaPogled : OblastPregled
    {
        public String TipZastite { get; set; }
        public OblastPovremenaIntervencijaPogled(int oId, String ime, float pov, int bs, int bz, int bb, int br, int bh, String Tip) : base(oId, ime, pov, bs, bz, bb, br, bh)
        {
            this.TipZastite = Tip;
        }
    }

    public class OblastStalnaZastitaPogled : OblastPregled
    {
        public String TipZastite { get; set; }
        public OblastStalnaZastitaPogled(int oId, String ime, float pov, int bs, int bz, int bb, int br, int bh, String Tip) : base(oId, ime, pov, bs, bz, bb, br, bh)
        {
            this.TipZastite = Tip;
        }
    }

    public class OblastBasic
    {
        public int OblastId { get; set; }
        public String Ime { get; set; }
        public float Povrsina { get; set; }
        public IList<NazivSelaOblastBasic> nazivSela { get; set; }
        public IList<HranilisteBasic> hranilista { get; set; }
        public IList<RadnikBasic> radnici { get; set; }
        public IList<BiljkaBasic> biljke { get; set; }

        public OblastBasic(int oid, String ime, float povrsina)
        {
            this.OblastId = oid;
            this.Ime = ime;
            this.Povrsina = povrsina;
            hranilista = new List<HranilisteBasic>();
            nazivSela = new List<NazivSelaOblastBasic>();
            radnici = new List<RadnikBasic>();
            biljke = new List<BiljkaBasic>();
        }

        public OblastBasic() {
            hranilista = new List<HranilisteBasic>();
            nazivSela = new List<NazivSelaOblastBasic>();
            radnici = new List<RadnikBasic>();
            biljke = new List<BiljkaBasic>();
        }
    }

    public class MonitoringBasic : OblastBasic
    {
        public String Tip_zastite { get; set; }

        public MonitoringBasic() { }

        public MonitoringBasic(int id, String ime, float povrsina, String tip) : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }

    public class PovremenaIntervencijaBasic : OblastBasic
    {
        public String Tip_zastite { get; set; }

        public PovremenaIntervencijaBasic() { }

        public PovremenaIntervencijaBasic(int id, String ime, float povrsina, String tip) : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }

    public class StalnaZastitaBasic : OblastBasic
    {
        public String Tip_zastite { get; set; }

        public StalnaZastitaBasic() { }

        public StalnaZastitaBasic(int id, String ime, float povrsina, String tip) : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }

    public class NazivSelaOblastBasic
    {
        public OblastBasic oblast { get; set; }
        public String imeSela { get; set; }
        public NazivSelaOblastBasic() { }
        public NazivSelaOblastBasic(OblastBasic oblast,String imeSela)
        {
            this.oblast = oblast;
            this.imeSela = imeSela;
        }
    }
    #endregion

    #region Biljka

    public class BiljkaBasic
    {
        public int BiljkaId { get; set; }
        public String LatinskiNaziv { get; set; }
        public IList<OblastBasic> pripadaOblasti { get; set; }
        public IList<LokalniNazivBiljkeBasic> LokalniNaziviBiljke { get; set; }

        public BiljkaBasic() {
            pripadaOblasti = new List<OblastBasic>();
            LokalniNaziviBiljke = new List<LokalniNazivBiljkeBasic>();
        }

        public BiljkaBasic(int id, String latinskiNaziv) {
            this.BiljkaId = id;
            this.LatinskiNaziv = latinskiNaziv;
        }

        public void DodajLokalniNaziv(LokalniNazivBiljkeBasic lnb)
        {
            this.LokalniNaziviBiljke.Add(lnb);
        }
    }

    public class LokalniNazivBiljkeBasic
    {
        public BiljkaBasic biljka { get; set; }
        public String LokalniNaziv { get; set; }

        public LokalniNazivBiljkeBasic() { }
        public LokalniNazivBiljkeBasic(String ime)
        {
            this.LokalniNaziv = ime;
        }
    }

    public class ZasticenaBiljkaBasic : BiljkaBasic
    {
        public BiljkaBasic biljka { get; set; }
        public int Broj_odluke { get; set; }
        public DateTime Datum_pocetka { get; set; }
        public ZasticenaBiljkaBasic() { }
        public ZasticenaBiljkaBasic(int id, String latinskiNaziv, int brOdluke, DateTime date) : base(id, latinskiNaziv)
        {
            this.Broj_odluke = brOdluke;
            this.Datum_pocetka = date;
        }
    }

    public class BiljkaPregled
    {
        public int Id_biljke { get; set; }
        public String LatinskiNaziv { get; set; }
        public String Zasticena { get; set; }


        public BiljkaPregled() { }
        public BiljkaPregled(int id, String latinskiNaziv, String zasticena)
        {
            this.Id_biljke = id;
            this.LatinskiNaziv = latinskiNaziv;
            this.Zasticena = zasticena;
        }

    }

    public class LokalniNazivBiljkePogled
    {
        public BiljkaPregled biljka { get; set; }
        public String Lokalni_naziv { get; set; }

        public LokalniNazivBiljkePogled() { }
        public LokalniNazivBiljkePogled(String LokalniNaziv)
        {
            this.Lokalni_naziv = LokalniNaziv;
        }
    }

    public class ZasticenaBiljkaPogled : BiljkaPregled
    {
        public int Br_odluke { get; set; }
        public DateTime Datum_pocetka { get; set; }

        public ZasticenaBiljkaPogled() { }
        public ZasticenaBiljkaPogled(int brOdluke, DateTime datumPocetka)
        {
            this.Br_odluke = brOdluke;
            this.Datum_pocetka = datumPocetka;
        }
    }
    #endregion

    #region Radnik

    public class RadnikBasic
    {
        public int Id_radnika { get; set; }
        public Int64 MaticniBroj { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Adresa { get; set; }
        public String TipPosla { get; set; }
        public OblastBasic oblast { get; set; }
        public RadnikBasic()
        {
            oblast = new OblastBasic();
        }

        public RadnikBasic(int id, Int64 mbr, String ime, String prezime, String adresa, String tipPosla, OblastBasic oblast)
        {
            this.Id_radnika = id;
            this.MaticniBroj = mbr;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.TipPosla = tipPosla;
            this.oblast = oblast;
        }
    }

    public class VolonterBasic : RadnikBasic {
        public VolonterBasic() { }
        public VolonterBasic(int id, Int64 mbr, String ime, String prezime, String adresa, String tipPosla, OblastBasic o) : base(id, mbr, ime, prezime, adresa, tipPosla, o) { }
    }

    public class StalnoZaposljenBasic : RadnikBasic
    {
        public int BrojRadneKnjizice { get; set; }
        public int BrojLicneKarte { get; set; }
        public String MestoIzdavanjaLK { get; set; }

        public StalnoZaposljenBasic() { }

        public StalnoZaposljenBasic(int id, Int64 mbr, String ime, String prezime, String adresa, String tipPosla, int brRadneKnjizice, int brLK, String mestoLk, OblastBasic o)
            : base(id, mbr, ime, prezime, adresa, tipPosla, o) {
            this.BrojRadneKnjizice = brRadneKnjizice;
            this.BrojLicneKarte = brLK;
            this.MestoIzdavanjaLK = mestoLk;
        }
    }
    #endregion

    #region Zivotinja
    public class ZivotinjaBasic
    {
        public int IdZivotinje { get; set; }
        public int SerijskiBrojPrstena { get; set; }
        public String LokalniNaziv { get; set; }
        public String LatinskiNaziv { get; set; }
        public String statusPticaSelica { get; set; }
        public IList<OblastBasic> pripadaOblasti { get; set; }
        public IList<PrimecenaJeBasic> Hranilista { get; set; }

        public ZivotinjaBasic()
        {
            pripadaOblasti = new List<OblastBasic>();
            Hranilista = new List<PrimecenaJeBasic>();
        }

        public ZivotinjaBasic(int id, int sbrPrstena, String lokalniNaziv, String LatinskiNaziv, String statusPtica)
        {
            this.IdZivotinje = id;
            this.SerijskiBrojPrstena = sbrPrstena;
            this.LokalniNaziv = lokalniNaziv;
            this.LatinskiNaziv = LatinskiNaziv;
            this.statusPticaSelica = statusPtica;
            this.pripadaOblasti = new List<OblastBasic>();
            Hranilista = new List<PrimecenaJeBasic>();
        }

    }

    public class PticaSelicaBasic : ZivotinjaBasic
    {
        public IList<PticaSelicaZemljeBasic> zemlje { get; set; }

        public PticaSelicaBasic()
        {
            zemlje = new List<PticaSelicaZemljeBasic>();
        }
        public PticaSelicaBasic(int id, int sbrPrstena, String lokalniNaziv, String LatinskiNaziv, String statusPtica) : base(id, sbrPrstena, lokalniNaziv, LatinskiNaziv, statusPtica)
        {
            zemlje = new List<PticaSelicaZemljeBasic>();
        }
    }

    public class PticaSelicaZemljeBasic
    {
        public ZivotinjaBasic zivotinja { get; set; }
        public String zemlja { get; set; }
        public PticaSelicaZemljeBasic()
        {

        }

        public PticaSelicaZemljeBasic(ZivotinjaBasic z, String zemlja)
        {
            this.zivotinja = z;
            this.zemlja = zemlja;
        }
    }
    #endregion

    #region Hraniliste

    public class HranilisteBasic
    {
        public int IdHranilista { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public OblastBasic pripadaOblasti { get; set; }
        public IList<PrimecenaJeBasic> zivotinje { get; set; }
        public int brojZivotinja { get; set; }

        public HranilisteBasic()
        {
            zivotinje = new List<PrimecenaJeBasic>();
        }

        public HranilisteBasic(int id,DateTime datumPocetka,DateTime datumKraja,OblastBasic pripadaOblasti)
        {
            this.IdHranilista = id;
            this.DatumPocetka = datumPocetka;
            this.DatumKraja = datumKraja;
            this.pripadaOblasti = pripadaOblasti;
            zivotinje = new List<PrimecenaJeBasic>();
        }
    }

    #endregion

    #region PrimecenaJe

    public class PrimecenaJeBasic
    {
        public ZivotinjaBasic zivotinja { get; set; }
        public HranilisteBasic hraniliste { get; set; }
        public DateTime DatumVidjenja { get; set; }

        public PrimecenaJeBasic()
        {
                
        }

        public PrimecenaJeBasic(ZivotinjaBasic zivotinja,HranilisteBasic hraniliste,DateTime datumVidjenja)
        {
            this.zivotinja = zivotinja;
            this.hraniliste = hraniliste;
            this.DatumVidjenja = datumVidjenja;
        }
    }

    #endregion
}
