using System;

namespace ParkPrirodeProjekat3.DTOs
{
    public class ZasticenaBiljkaView : BiljkaView
    {
        //public BiljkaView Biljka { get; set; }
        public int Broj_odluke { get; set; }
        public DateTime Datum_pocetka { get; set; }
        public ZasticenaBiljkaView() { }
        public ZasticenaBiljkaView(int id, String latinskiNaziv,string zasticena, int brOdluke, DateTime date) 
        : base(id, latinskiNaziv,zasticena)
        {
            this.Broj_odluke = brOdluke;
            this.Datum_pocetka = date;
        }
    }
}