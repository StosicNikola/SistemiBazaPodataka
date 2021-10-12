using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class PticeSeliceZivotinje
    {
        public virtual PticeSeliceZivotinjeId id { get; set; }

        public PticeSeliceZivotinje()
        {
            id = new PticeSeliceZivotinjeId();
        }
    }
}
