using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Apoteka;
using Apoteka.Entiteti;

namespace WebAPI.Controllers
{
    public class LekController : ApiController
    {

        // GET api/lek
        public IEnumerable<Lek> Get()
        {
            DTOManager provider = new DTOManager();

            IEnumerable<Lek> lekovi = provider.GetLekovi();

            //return new [] {
            //    new Vojnik() {Naziv="test"}
            //};

            return lekovi;
        }
        
        // GET api/lek/naziv
        public Lek Get(string komNaziv)  // BILO JE public VojnikView Get(int barkod)
        {
           DTOManager provider = new DTOManager();

            return provider.GetLek(komNaziv);
        }
        /*
        // POST api/
        public int Post([FromBody]Vojnik v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddVojnik(v);
        }

        // PUT api/vojnik/5
        public void Put(int id, [FromBody]Vojnik v)
        {
        }

        // DELETE api/vojnik/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveVojnik(id);
        }*/

    }
}
