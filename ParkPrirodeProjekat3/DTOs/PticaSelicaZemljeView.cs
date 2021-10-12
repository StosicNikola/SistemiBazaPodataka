using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class PticaSelicaZemljeView
    {
        [JsonIgnore]
        public ZivotinjaView zivotinja { get; set; }
        public string zemlja { get; set; }
        public PticaSelicaZemljeView()
        {

        }

        public PticaSelicaZemljeView(ZivotinjaView z, string zemlja)
        {
            this.zivotinja = z;
            this.zemlja = zemlja;
        }

        public PticaSelicaZemljeView(PticeSeliceZivotinje p)
        {
            this.zivotinja = new ZivotinjaView(p.id.Id_zivotinjeFK);
            this.zemlja = p.id.Zemlje;
        }
    }
}