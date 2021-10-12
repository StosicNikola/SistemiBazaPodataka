using System;
using ParkPrirodeProjekat3.Entiteti;
namespace ParkPrirodeProjekat3.DTOs
{
    public class StalnoZaposljenView : RadnikView
    {
        public int BrojRadneKnjizice { get; set; }
        public int BrojLicneKarte { get; set; }
        public string MestoIzdavanjaLK { get; set; }

        public StalnoZaposljenView() { }

        public StalnoZaposljenView(int id, Int64 mbr, string ime, string prezime, string adresa, string tipPosla, int brRadneKnjizice, int brLK, string mestoLk, OblastView o)
            : base(id, mbr, ime, prezime, adresa, tipPosla, o) {
            this.BrojRadneKnjizice = brRadneKnjizice;
            this.BrojLicneKarte = brLK;
            this.MestoIzdavanjaLK = mestoLk;
        }

        public StalnoZaposljenView(StalnoZaposlen r){
            this.Id_radnika = r.Id_radnika;
            this.MaticniBroj = r.Maticni_br;
            this.Ime = r.Ime;
            this.Prezime = r.Prezime;
            this.Adresa = r.Adresa;
            this.TipPosla = r.Tip_posla;
            this.BrojLicneKarte = r.Broj_licne_karte;
            this.BrojRadneKnjizice = r.Broj_radne_knjizice;
            this.MestoIzdavanjaLK = r.Mesto_izdavanja_lk;
        }
    }
}