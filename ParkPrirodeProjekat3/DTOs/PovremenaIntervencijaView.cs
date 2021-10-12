namespace ParkPrirodeProjekat3.DTOs
{
    public class PovremenaIntervencijaView : OblastView
    {
        public string Tip_zastite { get; set; }

        public PovremenaIntervencijaView() { }

        public PovremenaIntervencijaView(int id, string ime, float povrsina, string tip) 
        : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }
}