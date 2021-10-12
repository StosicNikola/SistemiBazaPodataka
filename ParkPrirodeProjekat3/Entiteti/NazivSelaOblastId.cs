using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirodeProjekat3.Entiteti
{
    public class NazivSelaOblastId
    {
        public virtual Oblast Id_oblastiFK { get; set; }
        public virtual String Naziv_sela { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(NazivSelaOblastId))
                return false;

            NazivSelaOblastId recievedObject = (NazivSelaOblastId)obj;

            if (Id_oblastiFK.Id_oblasti == recievedObject.Id_oblastiFK.Id_oblasti)
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
