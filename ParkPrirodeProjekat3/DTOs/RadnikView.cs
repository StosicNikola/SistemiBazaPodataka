using ParkPrirodeProjekat3.Entiteti;
using System;
using System.Text.Json.Serialization;
namespace ParkPrirodeProjekat3.DTOs
{
    public class RadnikView
    {
        public int Id_radnika { get; set; }
        public Int64 MaticniBroj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string TipPosla { get; set; }
        [JsonIgnore] 
        public OblastView Oblast { get; set; }
        public RadnikView()
        {
            Oblast = new OblastView();
        }

        public RadnikView(int id, Int64 mbr, string ime, string prezime, string adresa, string tipPosla, OblastView oblast)
        {
            this.Id_radnika = id;
            this.MaticniBroj = mbr;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.TipPosla = tipPosla;
            this.Oblast = oblast;
        }

        public RadnikView(Radnik r){
            this.Id_radnika = r.Id_radnika;
            this.MaticniBroj = r.Maticni_br;
            this.Ime = r.Ime;
            this.Prezime = r.Prezime;
            this.Adresa = r.Adresa;
            this.TipPosla = r.Tip_posla;
            //oblast?

        }
    }
}