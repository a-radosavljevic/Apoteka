using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;

namespace Apoteka.DTOs
{
    public class ProizvodjacView
    {
        public int idProizvodjaca { get; protected set; }
        public string imeProizvodjaca { get; set; }

        public ProizvodjacView() { }
        public ProizvodjacView(Proizvodjac p)
        {
            idProizvodjaca=p.idProizvodjaca;
            imeProizvodjaca=p.imeProizvodjaca;
        }

    }
}
