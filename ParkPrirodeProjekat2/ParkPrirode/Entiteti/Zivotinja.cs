using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class Zivotinja
    {
        public virtual int Id_zivotinje { get; set; }

        public virtual int Serijski_broj_prstena { get; set; }

        public virtual String Latinski_naziv { get; set; }

        public virtual String Lokalni_naziv { get; set; }

        public virtual String Ptica_selica { get; protected set; }

        public virtual IList<Oblast> Oblasti { get; set; }

        public virtual IList<Primecena_je> PrimecenaJeKodHranilista { get; set; }

        public Zivotinja()
        {
            Oblasti = new List<Oblast>();
            PrimecenaJeKodHranilista = new List<Primecena_je>();
        }
    }

    public class Ptice_selice : Zivotinja {
        public virtual IList<PticeSeliceZivotinje> zemlje { get; set; }

        public Ptice_selice()
        {
            zemlje = new List<PticeSeliceZivotinje>();
        }
    }
}
