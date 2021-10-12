using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class Primecena_je
    {
        public virtual PrimecenaJeId Id { get; set; }
        public virtual DateTime Datum_vidjenja { get; set; }

        public Primecena_je()
        {
            Id = new PrimecenaJeId();
        }
    }
}
