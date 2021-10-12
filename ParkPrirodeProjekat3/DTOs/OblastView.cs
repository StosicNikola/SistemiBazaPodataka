using System.Collections.Generic;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class OblastView
    {
        public int OblastId { get; set; }
        public string Ime { get; set; }
        public float Povrsina { get; set; }

        public IList<NazivSelaOblastView> NazivSela { get; set; }
        public IList<HranilisteView> Hranilista { get; set; }
        public IList<RadnikView> Radnici { get; set; }
        public IList<ZivotinjaView> Zivotinje {get; set;}
        public IList<BiljkaView> Biljke { get; set; }
        public OblastView(){

        }

        public OblastView(int oid, string ime, float povrsina)
        {
            this.OblastId = oid;
            this.Ime = ime;
            this.Povrsina = povrsina;
            Hranilista = new List<HranilisteView>();
            NazivSela = new List<NazivSelaOblastView>();
            Radnici = new List<RadnikView>();
            Biljke = new List<BiljkaView>();
            Zivotinje = new List<ZivotinjaView>();
        }

        public OblastView(Oblast o){
            
        }
    }
}