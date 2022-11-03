using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning031122
{
    internal class Butikk
    {
        
        private string Navn { get; set; }
        public List<Produkt> Produkter { get; set;  }

        public List<Kunde> KunderIbutikk { get; set; }
        public List<Ansatte> Ansatte { get; set; }

        public List<Dør> Dører { get; set; }

        public Kasse Kasse { get; set; }

       
        public Butikk(string navn)
        {
                Navn = navn;
                Produkter = new List<Produkt>();
                Ansatte = new List<Ansatte>();
                Dører = new List<Dør>();
                Kasse = new Kasse();
                leggtilProdukt();
        }

        public void leggtilProdukt()
        {
            Produkter.Add(new Produkt(1234, "Head sett",300));
        }


        public void printButikkInfo()
        {

            Console.WriteLine("Butikknavn: " + Navn + "Produkt: " + Produkter[0].HentProduktinfo());
        }

        public void Salg()
        {
            KunderIbutikk[0].kjøp(this);
        }

    }
}
