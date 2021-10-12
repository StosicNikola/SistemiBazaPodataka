using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
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
