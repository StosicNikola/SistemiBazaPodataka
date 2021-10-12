using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.Mapiranje
{
    class LokalniNazivBiljkeMapiranja: ClassMap<LokalniNazivBiljke>
    {
        public LokalniNazivBiljkeMapiranja() {

            Table("LOKALNI_NAZIV_BILJKE");

            // Map(x => x.Lokalni_naziv, "LOKALNI_NAZIV");

            //References(x => x.Pripada_biljki).Column("ID_BILJKEFK").LazyLoad();

            CompositeId(x => x.id)
                .KeyReference(x => x.Id_biljkeFK, "ID_BILJKEFK")
                .KeyProperty(x => x.Lokalni_naziv, "LOKALNI_NAZIV");
        }

    }
}
