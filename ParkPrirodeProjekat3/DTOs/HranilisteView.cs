using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class HranilisteView
    {
        public int IdHranilista { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        [JsonIgnore]
        public OblastView pripadaOblasti { get; set; }
        public IList<PrimecenaJeView> zivotinje { get; set; }
        public int brojZivotinja { get; set; }

        public HranilisteView()
        {
            zivotinje = new List<PrimecenaJeView>();
        }

        public HranilisteView(int id,DateTime datumPocetka,DateTime datumKraja,OblastView pripadaOblasti)
        {
            this.IdHranilista = id;
            this.DatumPocetka = datumPocetka;
            this.DatumKraja = datumKraja;
            this.pripadaOblasti = pripadaOblasti;
            zivotinje = new List<PrimecenaJeView>();
        }

         public HranilisteView(Hraniliste h)
        {
            this.IdHranilista = h.Id;
            this.DatumPocetka = h.Pocetni_datum;
            this.DatumKraja = h.Krajnji_datum;
            this.brojZivotinja = h.PrimecenaJeZivotinja.Count;
        }
    }
}