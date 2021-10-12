using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class Hraniliste
    {
        public virtual int Id { get; set; }
        public virtual DateTime Pocetni_datum { get; set; }
        public virtual DateTime Krajnji_datum { get; set; }
        public virtual Oblast PripadaOblasti { get; set; }
        public virtual IList<Primecena_je> PrimecenaJeZivotinja { get; set; }

        public Hraniliste()
        {
            PrimecenaJeZivotinja = new List<Primecena_je>();
        }
    }
}
