using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode.Mapiranje
{
    class ZivotinjaMapiranja: ClassMap<Zivotinja>
    {
        public ZivotinjaMapiranja()
        {
            Table("ZIVOTINJA");
            DiscriminateSubClassesOnColumn("PPTICA_SELICA", "Ne");

            Id(x => x.Id_zivotinje, "ID_ZIVOTINJE").GeneratedBy.TriggerIdentity();

            Map(x => x.Serijski_broj_prstena, "SERIJSKI_BR_PRSTENA");
            Map(x => x.Latinski_naziv, "LATINSKI_NAZIV");
            Map(x => x.Lokalni_naziv, "LOKALNI_NAZIV");

            HasManyToMany(x => x.Oblasti)
               .Table("PRIPADA")
               .ParentKeyColumn("ID_ZIVOTINJEFK")
               .ChildKeyColumn("ID_OBLASTIFK")
               .Cascade.All();
            HasMany(x => x.PrimecenaJeKodHranilista).KeyColumn("ID_ZIVOTINJEFK").Cascade.All().Inverse();
        }
    }

    class Ptice_selice_Mapiranja : SubclassMap<Ptice_selice>
    {
        public Ptice_selice_Mapiranja() {

            DiscriminatorValue("Da");
            HasMany(x => x.zemlje).KeyColumn("ID_ZIVOTINJEFK").LazyLoad().Cascade.All().Inverse();
        }
    }
}
