using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
namespace Sklep;
class Program
{
    public static void Main(string[] args)
    {
        
        int wybór = 0;
        int next = 0;
        Console.WriteLine("Jak chcesz nazwać sklep?");
        string Sklep = Console.ReadLine();
        Console.WriteLine($"Witamy w Sklepie {Sklep} !");
        Console.WriteLine("****************");
        Console.WriteLine("gdzie chcesz najpierw isć?");
        Console.WriteLine("****************");
        Console.WriteLine("****************");
        Console.WriteLine("1 - dział owoców");
        Console.WriteLine("2 - dział warzyw");
        Console.WriteLine("3 - dział słodyczy");

        wybór = Convert.ToInt32(Console.ReadLine());
        if (wybór == 1)
        {
            Owoce(wybór);
        }

        if (wybór == 2)
        {
            warzywa(wybór);
        }

        if (wybór == 3)
        {
            słodycze(wybór);
        }


        Owoce(wybór);

    }




    static void Owoce(int wybór)
    {
        
        int owoc = 0;
        int jabłko = 0;
        int gruszka = 0;
        int banan = 0;
        int pomarańcza = 0;
        int jagody = 0;
        Program program = new Program();


        Console.WriteLine("Wybierz artykuły z działu owoce!!");
        Console.Write("Jabłko(1)  ");
        Console.Write("Gruszka(2)  ");
        Console.Write("Banan(3)  ");
        Console.Write("Pomarańcza(4)  ");
        Console.Write("Jagody(5)  ");
        int wybór_owoca = Convert.ToInt32(Console.ReadLine());


        // switchem sprobować 
        switch (wybór_owoca)
        {
            case 1:
                jabłko++;
                Console.WriteLine("zebrano jabłko");
                break;
            case 2:
                gruszka++;
                Console.WriteLine("zebrano gruszke");
                break;
            case 3:
                banan++;
                Console.WriteLine("zebrano banana");
                break;
            case 4:
                pomarańcza++;
                Console.WriteLine("zebrano pomarancze");
                break;
            case 5:
                jagody++;
                Console.WriteLine("zebrano jagody");
                break;
        
        }
        Console.WriteLine("czy chcesz kontynuować zakupy?(1) czy chczesz juz kończyć zakupy (2)");
        int next = Convert.ToInt32(Console.ReadLine());
        if (next == 2)
        {
            Environment.Exit(0);

        }
        else
        {
         
        }
    }




    static void warzywa(int wybór)
    {
        int brokul = 0;
        int seler = 0;
        int pomidor = 0;
        int bakłażan = 0;
        int kapusta = 0;
        Console.WriteLine("Wybierz artykuły z działu warzywa!!");
        Console.Write("Brokuł(1)  ");
        Console.Write("Seler(2)  ");
        Console.Write("Pomidor(3)  ");
        Console.Write("Bakłażan(4)  ");
        Console.Write("Kapusta(5)  ");
        int wybór_warzywa = Convert.ToInt32(Console.ReadLine());

        switch (wybór_warzywa)
        {
            case 1:
                brokul++;
                Console.WriteLine("zebrano brokuł");
                break;
            case 2:
                seler++;
                Console.WriteLine("zebrano seler");
                break;
            case 3:
                pomidor++;
                Console.WriteLine("zebrano pomidor");
                break;
            case 4:
                bakłażan++;
                Console.WriteLine("zebrano bakłażan");
                break;
            case 5:
                kapusta++;
                Console.WriteLine("zebrano Kapsute");
                break;


        }

        Console.WriteLine("czy chcesz kontynuować zakupu w tym dziale? (1) czy chczesz zacząc od początku? (2)");
        int next = Convert.ToInt32(Console.ReadLine());

    }


    static void słodycze(int wybór)
    {
        int czekolada = 0;
        int batonik = 0;
        int cukierek = 0;
        int lizaki = 0;
        int żelki = 0;
        Console.WriteLine("Wybierz artykuły z działu słodycze!!");
        Console.Write("czekolada(1)  ");
        Console.Write("batonik(2)  ");
        Console.Write("cukierek(3)  ");
        Console.Write("lizaki(4)  ");
        Console.Write("żelki(5)  ");
        int wybór_słodycza = Convert.ToInt32(Console.ReadLine());

        switch (wybór_słodycza)
        {
            case 1:
                czekolada++;
                Console.WriteLine("zebrano czekolade");
                break;
            case 2:
                batonik++;
                Console.WriteLine("zebrano batonik");
                break;
            case 3:
                cukierek++;
                Console.WriteLine("zebrano cukierka");
                break;
            case 4:
                lizaki++;
                Console.WriteLine("zebrano lizaka");
                break;
            case 5:
                żelki++;
                Console.WriteLine("zebrano żelka");
                break;

           
        }


        Console.WriteLine("czy chcesz kontynuować zakupu w tym dziale? (1) czy chczesz zacząc od początku? (2)");
        int next = Convert.ToInt32(Console.ReadLine());
    }
}

