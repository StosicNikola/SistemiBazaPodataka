using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.Mapiranje
{
    class NazivSelaOblastMapiranja: ClassMap<NazivSelaOblast>
    {
        public NazivSelaOblastMapiranja()
        {
            Table("NAZIV_SELA_OBLAST");

            CompositeId(x => x.id)
               .KeyReference(x => x.Id_oblastiFK, "ID_OBLASTIFK")
               .KeyProperty(x => x.Naziv_sela, "NAZIV_SELA");
        }
    }
}
