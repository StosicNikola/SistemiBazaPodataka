namespace ParkPrirodeProjekat3.DTOs
{
    public class StalnaZastitaView : OblastView
    {
        public string Tip_zastite { get; set; }

        public StalnaZastitaView() { }

        public StalnaZastitaView(int id, string ime, float povrsina, string tip) 
        : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }
}