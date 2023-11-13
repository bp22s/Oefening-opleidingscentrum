using Opleidingscentrum;
using Opleidingscentrum.Infrastructuur;
using Opleidingscentrum.Personeel;

IKost[] kostenplaatsen = new IKost[5];
kostenplaatsen[0] = new Instructeur(1, "Jan", "Jansen", 1500m, Vakgebied.Ontwikkeling, "janjansenatvdab.be");
kostenplaatsen[1] = new Instructeur(2, "Roos", "Roosen", 1600m, Vakgebied.Ontwikkeling, "roos.roosen@vdab.be");
kostenplaatsen[2] = new Medewerker(3, "Piet", "Peeters", 1550m, 10);
kostenplaatsen[3] = new Gebouw("Einstein", 1500m);
kostenplaatsen[4] = new Gebouw("Newton", 2500m);
decimal totaleMaandKost = 0m;

Personeel.VerlofPeriode[] verlofPeriodes = new Personeel.VerlofPeriode[2];
verlofPeriodes[0] = new("Kerstvakantie", new DateOnly(2023, 12, 25), new DateOnly(2024, 1, 1));
verlofPeriodes[1] = new("Zomervakantie", new DateOnly(2023, 7, 1), new DateOnly(2023, 7, 31));

string tekst1 = "Collectieve verlofperiodes";
string tekst2 = "Kosten personeel en infrastructuur";

LijnenTrekker lijnenTrekker = new LijnenTrekker();
Console.WriteLine(tekst1);
lijnenTrekker.TekenLijn(tekst1.Length, '-');
    foreach (Personeel.VerlofPeriode verlofPeriode in verlofPeriodes)
    Console.WriteLine(verlofPeriode.ToonVerlofPeriode());

Console.WriteLine();
Console.WriteLine(tekst2);
lijnenTrekker.TekenLijn(tekst2.Length, '-');
foreach (IKost kostenplaats in kostenplaatsen)
{
    Console.WriteLine(kostenplaats.GegevensTonen());
    Console.WriteLine();
    totaleMaandKost += kostenplaats.MaandKost();
}
Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaleMaandKost:F0} euro");
