namespace Ispit.Model;

public class Ucenik
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string DatumRodjenja { get; set; }
    public double Prosjek { get; set; }

    public Ucenik()
    {
        Ime = string.Empty;
        Prezime = string.Empty;
        DatumRodjenja = "01.01.666.";
        Prosjek = 0.0d;
    }

    //internal void Starost()
    //{
    //    int starost = DateTime.Now.Year - DateTime.Parse(DatumRodjenja).Year;
    //    Console.WriteLine($"Starost: {starost}");
    //}

    internal int Starost()
    {
        return DateTime.Now.Year - DateTime.Parse(DatumRodjenja).Year;
    }

    //internal void IspisProsjeka()
    //{
    //    switch (Prosjek)
    //    {
    //        case >= 1.00 and <= 1.49:
    //            Console.WriteLine($"{Prosjek} = Nedovoljan!");
    //            break;
    //        case >= 1.50 and <= 2.49:
    //            Console.WriteLine($"{Prosjek} = Dovoljan!");
    //            break;
    //        case >= 2.50 and <= 3.49:
    //            Console.WriteLine($"{Prosjek} = Dobar!");
    //            break;
    //        case >= 3.50 and <= 4.49:
    //            Console.WriteLine($"{Prosjek} = Vrlo dobar!");
    //            break;
    //        case >= 4.50 and <= 5.0:
    //            Console.WriteLine($"{Prosjek} = Odlican!");
    //            break;
    //    }
    //}

    internal string IspisProsjeka()
    {
        switch (Prosjek)
        {
            case >= 1.00 and <= 1.49:
                return "Nedovoljan!";
            case >= 1.50 and <= 2.49:
                return "Dovoljan!";
            case >= 2.50 and <= 3.49:
                return "Dobar!";
            case >= 3.50 and <= 4.49:
                return "Vrlo dobar!";
            case >= 4.50 and <= 5.0:
                return "Odličan!";
            default:
                return "Neispravan!";
        }
    }

    public void Kreiraj()
    {
        Console.WriteLine("Unesite ime učenika:");
        Ime = Console.ReadLine();
        Console.WriteLine("Unesite prezime učenika:");
        Prezime = Console.ReadLine();
        Console.WriteLine("Unesite datum rođenja učenika (dd.MM.yyyy):");
        DatumRodjenja = Console.ReadLine();
        Console.WriteLine("Unesite prosjek učenika:");
        Prosjek = double.Parse(Console.ReadLine());
    }

    public void Ispisi()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Ime: {Ime}");
        Console.WriteLine($"Prezime: {Prezime}");
        Console.ResetColor();
        Console.WriteLine($"Datum rođenja: {DatumRodjenja}");
        //Starost();
        //IspisProsjeka();
        Console.WriteLine($"Starost: {Starost()}");
        Console.WriteLine($"Prosjek {Prosjek} je {IspisProsjeka()}");
    }
}