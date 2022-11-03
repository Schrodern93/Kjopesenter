// See https://aka.ms/new-console-template for more information

using Undervisning031122;

Console.WriteLine("Hello, World!");

var kjøpesenter = new Kjøpesenter();
//var kommandoklasse = new Kommandoklasse();

Console.WriteLine("Skriv inn navn på butikk");
var butikknavn = Console.ReadLine();

var butikk = new Butikk(butikknavn);

kjøpesenter.leggTilButikk(butikk);
kjøpesenter.SkrivUtAllInfo();



// kjøpesenter 
// butikker => produkter
// kunder
// ansatte
// toaletter
// lekeplass
// minibank
// informasjon
// innganger // dører
// parkeringsplasser


//Console.WriteLine(1);
//Console.WriteLine("adsfas");
// verksted 

// deres valg 