using System;

namespace ParkPrirodeProjekat3.DTOs
{
    public class VolonterView : RadnikView
    {
        public VolonterView() { }
        public VolonterView(int id, Int64 mbr, string ime, string prezime, string adresa, string tipPosla, OblastView o) 
        : base(id, mbr, ime, prezime, adresa, tipPosla, o) { }
    }
}