﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Entiteti;


namespace Apoteka.DTOs
{
    public class PakovanjeView
    {
        public virtual int idPakovanja { get; set; }
        public virtual int kolicina { get; set; }
        public virtual string sastav { get; set; }
        public virtual string tipPakovanja { get; set; }
        public virtual LekView pakujeLek { get; set; }


        public PakovanjeView(Pakovanje p)
        {
            this.idPakovanja = p.idPakovanja;
            this.kolicina = p.kolicina;
            this.sastav = p.sastav;
            this.tipPakovanja = p.tipPakovanja;
            this.pakujeLek = new LekView(p.pakujeLek);
        }

        public PakovanjeView()
        { }
    }
}
