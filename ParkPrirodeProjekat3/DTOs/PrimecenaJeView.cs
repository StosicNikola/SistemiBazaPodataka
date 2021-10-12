using System;
using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;
namespace ParkPrirodeProjekat3.DTOs
{
    public class PrimecenaJeView
    {
        [JsonIgnore]
        public ZivotinjaView zivotinja { get; set; }
        [JsonIgnore]
        public HranilisteView hraniliste { get; set; }

        public int IdHranilista {get; set;}
        public String LokalniNazivZivotinje {get; set;}
        public DateTime DatumVidjenja { get; set; }

        public PrimecenaJeView()
        {
                
        }

        public PrimecenaJeView(ZivotinjaView zivotinja,HranilisteView hraniliste,DateTime datumVidjenja)
        {
            this.zivotinja = zivotinja;
            this.hraniliste = hraniliste;
            this.DatumVidjenja = datumVidjenja;
            this.IdHranilista = hraniliste.IdHranilista;
        }

        public PrimecenaJeView(Primecena_je p){
            this.zivotinja = new ZivotinjaView(p.Id.Id_zivotinje);
            this.hraniliste = new HranilisteView(p.Id.Id_hranilista);
            this.DatumVidjenja = p.Datum_vidjenja;
            this.IdHranilista = p.Id.Id_hranilista.Id;
            this.LokalniNazivZivotinje = p.Id.Id_zivotinje.Lokalni_naziv;
        }
      
    }
}