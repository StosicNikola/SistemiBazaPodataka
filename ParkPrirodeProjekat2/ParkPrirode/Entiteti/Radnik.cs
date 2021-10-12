using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrirode.Entiteti
{
    public abstract class Radnik
    {
        public virtual int Id_radnika { get; protected set; }
        public virtual Int64 Maticni_br { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Adresa { get; set; }
        public virtual String Tip_posla { get; set; }
        public virtual Oblast pripadaOblasti { get; set; }

        public Radnik()
        {

        }
    }

    public class Volonter : Radnik {
    }

    public class StalnoZaposlen : Radnik {
        public virtual int Broj_radne_knjizice { get; set; }
        public virtual int Broj_licne_karte { get; set; }
        public virtual String Mesto_izdavanja_lk { get; set; }

    }
}
