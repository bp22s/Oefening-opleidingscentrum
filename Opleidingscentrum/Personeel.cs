namespace Opleidingscentrum.Personeel;
public partial class Personeel : IKost
{
    private int personeelsnummer;
    public int Personeelsnummer { get; init; }
    private string voornaam;
    public string Voornaam { get; set; }
    private string familienaam;
    public string Familienaam { get; set; }
    private decimal brutomaandloon;
    public decimal Brutomaandloon
    {
        get
        {
            return brutomaandloon;
        }
        set
        {
            if (value >= 0m)
            {
                brutomaandloon = value;
            }
        }
    }
    public Personeel(int personeelsnummer, string voornaam, string familienaam, decimal brutomaandloon)
    {
        Personeelsnummer = personeelsnummer;
        Voornaam = voornaam;
        Familienaam = familienaam;
        Brutomaandloon = brutomaandloon;
    }
    public decimal MaandKost() => Brutomaandloon * 0.6m;

    public virtual string GegevensTonen()
    {
        return
            $"Personeelsnummer {Personeelsnummer}\n" +
            $"Naam: {Voornaam} {Familienaam}\n" + 
            $"Brutomaandloon: {Brutomaandloon}";
    }
}
public partial class Personeel : IKost
{
    public class VerlofPeriode
    {
        private string? naam;
        public string? Naam { get; set; }
        private DateOnly begindatum;
        public DateOnly Begindatum { get; set; }
        private DateOnly einddatum;
        public DateOnly Einddatum
        {
            get => einddatum;
            set
            {
                if (value > begindatum)
                {
                    einddatum = value;
                }
            }
        }
        public VerlofPeriode(string naam, DateOnly begindatum, DateOnly einddatum)
        {
            Naam = naam;
            Begindatum = begindatum;
            Einddatum = einddatum;
        }
        public string ToonVerlofPeriode()
        {
            return $"Verlofperiode {Naam}: {Begindatum} - {Einddatum}";
        } 
    }
}
