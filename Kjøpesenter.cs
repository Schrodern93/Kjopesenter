using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary4;

namespace Undervisning031122
{
    internal class Kjøpesenter
    {
        //public Class1 class1 { get; set; }
        public List<Butikk> Butikker { get; set; }
        public List<Kunde> Kunder { get; set; }

        public int Toaletter { get; set; }

        public Lekeplass Lekeplass {get; set; }

        public List<Dør> Innganger { get; set; }
        public int Parkeringsplasser { get; set; }

        public Minibank Minibank { get; set; }
        public Info Info { get; set; }


        public Kjøpesenter()
        {
            Butikker = new List<Butikk>();
            Kunder = new List<Kunde>();
            Toaletter = 6;
            Lekeplass = new Lekeplass();
            Innganger = new List<Dør>();
            Parkeringsplasser = 100;
            Minibank = new Minibank();
            Info = new Info();
        }

        public void leggTilButikk( Butikk butikk)
        {
            Butikker.Add(butikk);
        }

        public void SkrivUtAllInfo()
        {
            foreach (var Butikk in Butikker)
            {
                Butikk.printButikkInfo();
            }
        }
    }
}
