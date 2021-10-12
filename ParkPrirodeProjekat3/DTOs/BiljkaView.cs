using System.Collections.Generic;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class BiljkaView
    {
        public int BiljkaId { get; set; }
        public string LatinskiNaziv { get; set; }
        public string Zasticena {get; set;}
        public IList<OblastView> PripadaOblasti { get; set; }
        public IList<LokalniNazivBiljkeView> LokalniNazivi { get; set; }

        public BiljkaView(){
            this.PripadaOblasti = new List<OblastView>();
            this.LokalniNazivi = new List<LokalniNazivBiljkeView>();
        }

        public BiljkaView(int id,string Latinski_naziv,string zasticena){
            this.BiljkaId = id;
            this.LatinskiNaziv = Latinski_naziv;
            this.Zasticena = zasticena;
        }

        public BiljkaView(Biljka b){
            this.BiljkaId = b.Id_biljke;
            this.LatinskiNaziv = b.Latinski_naziv;
          //  this.LokalniNazivi = b.LokalniNazivi;
          //  this.PripadaOblasti = (IList<OblastView>)b.Oblasti;
        }
         
    }
}