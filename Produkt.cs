namespace Undervisning031122
{
    public class Produkt
    {
        private int Varenummer;
        public string Navn;
        //public Størrelse størrelse;
        public int Pris;

        public Produkt(int varenummer, string navn, int pris)
        {
           Varenummer = varenummer;
            Navn = navn;
            Pris = pris;
        }

        public string HentProduktinfo()
        {
            return "Varenummer: " + Varenummer + " Navn: " + Navn + " Pris: " + Pris;
        }
    }
    
}