using Ispit.Model;
namespace Ispit.Konzola;

internal class Program
{
    static void Main(string[] args)
    {
        List<Ucenik> ucenici = new();
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Unesite podatke {0}. učenika:", i);
            Ucenik ucenik = new ();
            ucenik.Kreiraj();
            ucenici.Add(ucenik);
        }

        foreach (Ucenik dzak in ucenici)
        {
            Console.WriteLine();
            dzak.Ispisi();
        }
    }
    
}



