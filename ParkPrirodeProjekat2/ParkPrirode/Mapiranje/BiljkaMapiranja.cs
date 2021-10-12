using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirode.Entiteti;

namespace ParkPrirode.Mapiranje
{
    class BiljkaMapiranja : ClassMap<Biljka>
    {
        public BiljkaMapiranja()
        {
            Table("BILJKA");

            Id(x => x.Id_biljke, "ID_BILJKE").GeneratedBy.TriggerIdentity();

            Map(x => x.Latinski_naziv, "LATINSKI_NAZIV");

            HasMany(x => x.LokalniNazivi).KeyColumn("ID_BILJKEFK").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Oblasti)
               .Table("RASTE")
               .ParentKeyColumn("ID_BILJKEFK")
               .ChildKeyColumn("ID_OBLASTIFK")
               .Cascade.All();

        }
    }

    class ZasticenaBiljkaMapiranja : SubclassMap<ZasticenaBiljka> {
        public ZasticenaBiljkaMapiranja()
        {
            Table("ZASTICENA_BILJKA");

            KeyColumn("ID_BILJKE");

            Map(x => x.Broj_odluke).Column("BR_ODLUKE");
            Map(x => x.Datum_pocetka).Column("DATUM_POCETKA");


        }
    }
}
