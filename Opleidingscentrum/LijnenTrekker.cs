namespace Opleidingscentrum;
public class LijnenTrekker
{
    public void TekenLijn(int lengte, char teken)
    {
        for (int teller = 0; teller < lengte; teller++)
            Console.Write(teken);
        Console.WriteLine();
    }
}
