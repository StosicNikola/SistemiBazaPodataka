using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirode.Entiteti;

namespace ParkPrirode.Mapiranje
{
    class OblastMapiranja : ClassMap<Oblast>
    {
        public OblastMapiranja()
        {
            Table("OBLAST");

            DiscriminateSubClassesOnColumn("TIP_ZASTITE");

            Id(x => x.Id_oblasti, "ID_OBLAST").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Povrsina, "POVRSINA");
            HasMany(x => x.Naziv_sela).KeyColumn("ID_OBLASTIFK").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Biljke)
                .Table("RASTE")
                .ParentKeyColumn("ID_OBLASTIFK")
                .ChildKeyColumn("ID_BILJKEFK")
                .Cascade.All()
                .Inverse();

            HasManyToMany(x => x.Zivotinje)
                .Table("PRIPADA")
                .ParentKeyColumn("ID_OBLASTIFK")
                .ChildKeyColumn("ID_ZIVOTINJEFK")
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Radnici).KeyColumn("ID_OBLASTIFK").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Hranilista).KeyColumn("ID_OBLASTI").LazyLoad().Cascade.All().Inverse();
        }
    }

    class OblastMonitoringMapiranja : SubclassMap<OblastMonitoring>
    {
        public OblastMonitoringMapiranja()
        {
            DiscriminatorValue("Monitoring");
        }
    }

    class OblastStalnaZastitaMapiranja : SubclassMap<OblastStalnaZastita>
    {
        public OblastStalnaZastitaMapiranja()
        {
            DiscriminatorValue("Stalna_zastita");
        }
    }

    class OblastPovremenaZastitaMapiranja : SubclassMap<OblastPovremenaZastita>
    {
        public OblastPovremenaZastitaMapiranja()
        {
            DiscriminatorValue("Povremena_intervencija");
        }

    }
}
