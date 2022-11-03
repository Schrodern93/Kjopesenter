namespace Undervisning031122
{
    public class Kunde
    {
        public List<Produkt> Handlekurv;

        public Butikk butikk;

        public void kjøp(Butikk butikk)
        {
            butikk.Produkter[0].Antall -= 1;
        }

    }
}