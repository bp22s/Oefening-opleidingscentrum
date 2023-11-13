namespace Opleidingscentrum.Personeel;
internal class Medewerker : Personeel
{
    public Medewerker(int personeelsnummer, string voornaam, string familienaam, decimal brutomaandloon, int aantalCursisten)
        : base(personeelsnummer, voornaam, familienaam, brutomaandloon)
    {
        AantalCursisten = aantalCursisten;
    }
    private int aantalCursisten;
    public int AantalCursisten
    {
        get
        {
            return aantalCursisten;
        }
        set
        {
            if (value >= 0)
            {
                aantalCursisten = value;
            }
        }
    }
    public override string GegevensTonen()
    {
        return
              $"{base.GegevensTonen()}\n" +
              $"Medewerker: {AantalCursisten} cursisten\n" +
              $"Maandlijkse kost: {base.MaandKost():F0} euro";
    }
}
