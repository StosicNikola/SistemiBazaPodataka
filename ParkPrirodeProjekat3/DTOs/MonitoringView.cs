namespace ParkPrirodeProjekat3.DTOs
{
    public class MonitoringView : OblastView
    {
        public string Tip_zastite { get; set; }

        public MonitoringView() { }

        public MonitoringView(int id, string ime, float povrsina, string tip) 
        : base(id, ime, povrsina)
        {
            this.Tip_zastite = tip;
        }
    }
}