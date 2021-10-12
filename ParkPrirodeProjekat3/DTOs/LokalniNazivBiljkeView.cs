using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;
namespace ParkPrirodeProjekat3.DTOs
{
    public class LokalniNazivBiljkeView
    {
        [JsonIgnore]
        public BiljkaView Biljka { get; set; }
        public string LokalniNaziv { get; set; }
        public LokalniNazivBiljkeView(){

        }
        public LokalniNazivBiljkeView(string ime){
            this.LokalniNaziv = ime;
        }
        public LokalniNazivBiljkeView(LokalniNazivBiljke lnz){
            this.Biljka = new BiljkaView(lnz.id.Id_biljkeFK);
            this.LokalniNaziv = lnz.id.Lokalni_naziv;
        }
    }
}