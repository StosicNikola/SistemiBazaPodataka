using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirodeProjekat3.Entiteti
{
    public class PticeSeliceZivotinjeId
    {
        public virtual Zivotinja Id_zivotinjeFK { get; set; }
        public virtual String Zemlje { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PticeSeliceZivotinjeId))
                return false;

            PticeSeliceZivotinjeId recievedObject = (PticeSeliceZivotinjeId)obj;

            if (Id_zivotinjeFK.Id_zivotinje == recievedObject.Id_zivotinjeFK.Id_zivotinje)
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
