namespace Opleidingscentrum.Infrastructuur;
public class Gebouw :IKost
{
    private string naam;
    public string Naam
    {
        get => naam;
        set
        {
            if (value != string.Empty)
            {
                naam = value;
            }
        }
    }
    private decimal huurprijsPerMaand;
    public decimal HuurprijsPerMaand
    {
        get => huurprijsPerMaand;
        set
        {
            if (value >= 0m)
            {
                huurprijsPerMaand = value;
            }
        }
    }
    public Gebouw(string naam, decimal huurprijsPerMaand)
    {
        Naam = naam;
        HuurprijsPerMaand = huurprijsPerMaand;
    }

    public decimal MaandKost() => HuurprijsPerMaand;

    public string GegevensTonen()
    {
        return
            $"Gebouw {Naam} - Huurprijs per maand: {HuurprijsPerMaand} euro\n" +
            $"Maandlijkse kost: {HuurprijsPerMaand} euro";
    }
}
