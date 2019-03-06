using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class LekView
    {
        public string komercijalniNaziv { get; set; }
        public string hemijskiNaziv { get; set; }
        public string nacinDoziranjaZaOdrasle { get; set; }
        public string nacinDoziranjaZaDecu { get; set; }
        public string nacinDoziranjaZaTrudnice { get; set; }
        public int cenaLeka { get; set; }
        public int? procenatParticipacije { get; set; }
        public string izdavanjeNaRecept { get; set; }
        public string dejstvoLeka { get; set; }
        public string tip { get; set; }
        public ProizvodjacView pripadaProizvodjacu { get; set; }


        public LekView() { }
        public LekView(Lek l)
        {
            komercijalniNaziv = l.komercijalniNaziv;
            hemijskiNaziv = l.hemijskiNaziv;
            nacinDoziranjaZaDecu = l.nacinDoziranjaZaDecu;
            nacinDoziranjaZaOdrasle = l.nacinDoziranjaZaOdrasle;
            nacinDoziranjaZaTrudnice = l.nacinDoziranjaZaTrudnice;
            cenaLeka = l.cenaLeka;
            procenatParticipacije = l.procenatParticipacije;
            izdavanjeNaRecept = l.izdavanjeNaRecept;
            dejstvoLeka = l.dejstvoLeka;
            tip = l.tip;
            pripadaProizvodjacu = new ProizvodjacView(l.pripadaProizvodjacu);

        }
    }
}
