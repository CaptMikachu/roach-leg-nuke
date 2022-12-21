using System;

    class Program
{
        static void Main(string[] args)
    {
    Alku: Console.WriteLine("Torakka-Jalka-Ydinase. Valitse 1-4.");
    Console.WriteLine("1) Torakka 2) Jalka 3) Ydinase 4) Poistu");

        int valinta = int.Parse(Console.ReadKey().KeyChar.ToString());
        int puterChoise;
        string tulos = "";

        switch (valinta)
        {
            case 1:
                Console.Write(" Torakka!\n\r");
                break;

            case 2:
                Console.Write(" Jalka!\n\r");
                break;

            case 3:
                Console.Write(" Ydinase!\n\r");
                break;

            case 4:
                goto Loppu;

            default:
                Console.WriteLine("En ymmärrä vastaustasi, yritä uudestaan.");
                goto Alku;
        }

        Random randomNumb = new Random();
        puterChoise = randomNumb.Next(1, 5);

        if (valinta == puterChoise)
        {
            tulos = " Tasapeli!";
        }
        if (valinta == 2 && puterChoise == 1 || valinta == 3 && puterChoise == 2 || valinta == 1 && puterChoise == 3)
        {
            tulos = " Sinä voitit!";
        }
        if (valinta == 1 && puterChoise == 2 || valinta == 2 && puterChoise == 3 || valinta == 3 && puterChoise == 1)
        {
            tulos = " Tietokone voitti!";
        }

        switch (puterChoise)
        {
            case 1:
                Console.WriteLine("Tietokone valitsi: Torakka." + tulos + " Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
                goto Alku;

            case 2:
                Console.WriteLine("Tietokone valitsi: Jalka." + tulos + " Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
                goto Alku;

            case 3:
                Console.WriteLine("Tietokone valitsi: Ydinase." + tulos + " Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
                goto Alku; ;

            case 4:
                Console.WriteLine("Tietokone valitsi 4 ja haluaa poistua pelistä, mutta se ei ole reilua. Paina Enteriä jatkaaksesi.");
                Console.ReadLine();
                goto Alku;
        }

    Console.ReadKey();
    Loppu:;
    }
}
