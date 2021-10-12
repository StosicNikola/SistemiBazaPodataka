using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ParkPrirode.Entiteti;

namespace ParkPrirode.Mapiranje
{
    class RadnikMapiranja : ClassMap<Radnik>
    {
        public RadnikMapiranja()
        {
            Table("RADNIK");

            Id(x => x.Id_radnika, "ID_RADNIKA").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP_POSLA");
            

            Map(x => x.Maticni_br).Column("MATICNI_BR");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            References(x => x.pripadaOblasti).Column("ID_OBLASTIFK").LazyLoad();
           
        }
    }

    class VolonterMapiranja : SubclassMap<Volonter>
    {
        public VolonterMapiranja()
        {
            DiscriminatorValue("Volonter");
        }
    }
    
    class StalnoZaposljenMapiranje : SubclassMap<StalnoZaposlen>
    {
        public StalnoZaposljenMapiranje()
        {
            DiscriminatorValue("Stalno_zaposlen");
      
            Map(x =>x.Broj_radne_knjizice).Column("BR_RADNE_KNJIZICE");
            Map(x => x.Broj_licne_karte, "BROJLK");
            Map(x => x.Mesto_izdavanja_lk, "MESTOLK");

        }
    }
}
