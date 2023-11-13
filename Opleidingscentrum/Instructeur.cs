namespace Opleidingscentrum.Personeel;
internal class Instructeur : Personeel
{
    public Instructeur(int personeelsnummer, string voornaam, string familienaam, decimal brutomaandloon, Vakgebied vakgebied, string emailadres)
        : base(personeelsnummer, voornaam, familienaam, brutomaandloon)
    {
        Vakgebied = vakgebied;
        Emailadres = emailadres;
    }
    public Vakgebied Vakgebied { get; set; }
    private string emailadres;
    public string Emailadres
    {
        get
        {
            return emailadres;
        }
        set
        {
            if (value.Contains("@"))
            {
                emailadres = value;
            }
            else
            {
                emailadres = "onbekend emailadres";
            }
        }
    }
    public override string GegevensTonen()
    {
      return 
            $"{base.GegevensTonen()}\n" +
            $"Instructeur {Vakgebied} (e-mail: {Emailadres})\n" +
            $"Maandlijkse kost: {base.MaandKost():F0} euro";
    }
}
