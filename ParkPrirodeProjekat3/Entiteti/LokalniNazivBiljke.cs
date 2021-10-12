using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirodeProjekat3.Entiteti
{
    public class LokalniNazivBiljke
    {
        
        public virtual LokalniNazivBiljkeId id { get; set; }
        

        public LokalniNazivBiljke()
        {
            id = new LokalniNazivBiljkeId();
        }
    }
}
