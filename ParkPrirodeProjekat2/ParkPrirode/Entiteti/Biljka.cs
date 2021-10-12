using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class Biljka
    {
        public virtual int Id_biljke { get; protected set; }

        public virtual String Latinski_naziv { get; set; }

        public virtual IList<LokalniNazivBiljke> LokalniNazivi { get; set; }

        public virtual IList<Oblast> Oblasti { get; set; }

        public Biljka()
        {
            LokalniNazivi = new List<LokalniNazivBiljke>();
            Oblasti = new List<Oblast>();
        }

    }

    public class ZasticenaBiljka : Biljka {
        //public virtual Biljka IdBiljke { get; set; }

        public virtual int Broj_odluke { get; set; }

        public virtual DateTime Datum_pocetka { get; set; }
    }

}
