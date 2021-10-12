using System.Collections.Generic;

using ParkPrirodeProjekat3.Entiteti;

namespace ParkPrirodeProjekat3.DTOs
{
    public class PticaSelicaView : ZivotinjaView
    {
        public IList<PticaSelicaZemljeView> zemlje { get; set; }

        public PticaSelicaView()
        {
            zemlje = new List<PticaSelicaZemljeView>();
        }
        public PticaSelicaView(int id, int sbrPrstena, string lokalniNaziv, string LatinskiNaziv, string statusPtica) 
        : base(id, sbrPrstena, lokalniNaziv, LatinskiNaziv, statusPtica)
        {
            zemlje = new List<PticaSelicaZemljeView>();
        }

        public PticaSelicaView(Ptice_selice p) 
        : base(p.Id_zivotinje, p.Serijski_broj_prstena, p.Lokalni_naziv, p.Latinski_naziv, "Da")
        {
            zemlje = new List<PticaSelicaZemljeView>();
        }
    }
}