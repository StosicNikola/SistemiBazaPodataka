using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.Mapiranje
{
    class PticeSeliceZivotinjeMapiranje : ClassMap<PticeSeliceZivotinje>
    {
        public PticeSeliceZivotinjeMapiranje()
        {
            Table("PTICE_SELICE_ZIVOTINJE");

            CompositeId(x => x.id)
               .KeyReference(x => x.Id_zivotinjeFK, "ID_ZIVOTINJEFK")
               .KeyProperty(x => x.Zemlje, "ZEMLJA");
        }
    }
}
