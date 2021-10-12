using System.Collections.Generic;
using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;
namespace ParkPrirodeProjekat3.DTOs
{
    public class ZivotinjaView
    {
        public int IdZivotinje { get; set; }
        public int SerijskiBrojPrstena { get; set; }
        public string LokalniNaziv { get; set; }
        public string LatinskiNaziv { get; set; }
        public string statusPticaSelica { get; set; }
       
        [JsonIgnore]
        public IList<OblastView> pripadaOblasti { get; set; }
        public IList<PrimecenaJeView> Hranilista { get; set; }

        public ZivotinjaView()
        {
            pripadaOblasti = new List<OblastView>();
            Hranilista = new List<PrimecenaJeView>();
        }

        public ZivotinjaView(int id, int sbrPrstena, string lokalniNaziv, string LatinskiNaziv, string statusPtica)
        {
            this.IdZivotinje = id;
            this.SerijskiBrojPrstena = sbrPrstena;
            this.LokalniNaziv = lokalniNaziv;
            this.LatinskiNaziv = LatinskiNaziv;
            this.statusPticaSelica = statusPtica;
            this.pripadaOblasti = new List<OblastView>();
            Hranilista = new List<PrimecenaJeView>();
        }

         public ZivotinjaView(Zivotinja z)
        {
            this.IdZivotinje = z.Id_zivotinje;
            this.SerijskiBrojPrstena = z.Serijski_broj_prstena;
            this.LokalniNaziv = z.Lokalni_naziv;
            this.LatinskiNaziv = z.Latinski_naziv;
            this.statusPticaSelica = z.Ptica_selica;
            if(z.GetType() == typeof(Ptice_selice)){
                this.statusPticaSelica = "Da";
            }
            else{
                this.statusPticaSelica = "Ne";
            }
        }
    }
}