using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkPrirode.Entiteti;
using FluentNHibernate.Mapping;

namespace ParkPrirode.Mapiranje
{
    class HranilisteMapiranja : ClassMap<Hraniliste>
    {
        public HranilisteMapiranja()
        {
            Table("HRANILISTE");

            Id(x => x.Id, "ID_HRANILISTA").GeneratedBy.TriggerIdentity();

            Map(x => x.Pocetni_datum, "POCETNI_MESEC");
            Map(x => x.Krajnji_datum, "KRAJNJI_MESEC");
            References(x => x.PripadaOblasti).Column("ID_OBLASTI").LazyLoad();
            HasMany(x => x.PrimecenaJeZivotinja).KeyColumn("ID_HRANILISTAFK").Cascade.All();
        }
    }
}
