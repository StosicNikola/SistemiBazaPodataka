using System.Text.Json.Serialization;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class NazivSelaOblastView
    {
        [JsonIgnore]
        public OblastView oblast { get; set; }
        public string imeSela { get; set; }
        public NazivSelaOblastView() { }
        public NazivSelaOblastView(OblastView oblast,string imeSela)
        {
            this.oblast = oblast;
            this.imeSela = imeSela;
        }
        public NazivSelaOblastView(NazivSelaOblast nso )
        {
            oblast = new OblastView(nso.id.Id_oblastiFK);
            this.imeSela = nso.id.Naziv_sela;
        }
    }
}