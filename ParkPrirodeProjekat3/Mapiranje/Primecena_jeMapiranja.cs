using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.Mapiranje
{
    class Primecena_jeMapiranja : ClassMap<Primecena_je>
    {
        public Primecena_jeMapiranja()
        {
            Table("PRIMECENA_JE");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Id_zivotinje, "ID_ZIVOTINJEFK")
                .KeyReference(x => x.Id_hranilista, "ID_HRANILISTAFK");

            Map(x => x.Datum_vidjenja, "DATUM_VIDJENJA");
        }
    }
}
