using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirodeProjekat3.Entiteti
{
    public class PrimecenaJeId
    {
        public virtual Zivotinja Id_zivotinje { get; set; }
        public virtual Hraniliste Id_hranilista { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PrimecenaJeId))
                return false;

            PrimecenaJeId recievedObject = (PrimecenaJeId)obj;

            if ((Id_zivotinje.Id_zivotinje == recievedObject.Id_zivotinje.Id_zivotinje)&& (Id_hranilista.Id == recievedObject.Id_hranilista.Id))
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
