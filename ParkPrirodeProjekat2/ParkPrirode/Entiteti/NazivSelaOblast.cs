using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class NazivSelaOblast
    {
        public virtual NazivSelaOblastId id {  get; set; }

        public NazivSelaOblast()
        {
            id = new NazivSelaOblastId();
        }
    }
}
