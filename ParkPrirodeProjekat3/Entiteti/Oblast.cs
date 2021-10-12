using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirodeProjekat3.Entiteti
{
    public abstract class Oblast //oblast je proglasena za apstraknu klasu jer mora da ima barem jedan od tri tipa zastite
    {
        public virtual int Id_oblasti { get; protected set; }

        public virtual String Ime { get; set; }

        public virtual float Povrsina { get; set; }

        public virtual IList<NazivSelaOblast> Naziv_sela { get; set; }

        public virtual String Tip_zastite { get; set; }

        public virtual IList<Biljka> Biljke { get; set; }

        public virtual IList<Zivotinja> Zivotinje { get; set; }

        public virtual IList<Radnik> Radnici { get; set; }

        public virtual IList<Hraniliste> Hranilista { get; set; }


        public Oblast()
        {
            Naziv_sela = new List<NazivSelaOblast>();
            Biljke = new List<Biljka>();
            Zivotinje = new List<Zivotinja>();
            Radnici = new List<Radnik>();
            Hranilista = new List<Hraniliste>();
        }
    }

    public class OblastMonitoring : Oblast { }

    public class OblastStalnaZastita : Oblast { }

    public class OblastPovremenaZastita : Oblast { }
}
