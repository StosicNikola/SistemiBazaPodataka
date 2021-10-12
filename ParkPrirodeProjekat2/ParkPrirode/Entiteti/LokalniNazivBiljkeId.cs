using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public class LokalniNazivBiljkeId
    {
        public virtual Biljka Id_biljkeFK { get; set; }
        public virtual String Lokalni_naziv { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(LokalniNazivBiljkeId))
                return false;

            LokalniNazivBiljkeId recievedObject = (LokalniNazivBiljkeId)obj;

            if (Id_biljkeFK.Id_biljke == recievedObject.Id_biljkeFK.Id_biljke) 
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
