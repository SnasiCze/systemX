using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace systemX
{
    class math
    {
        #region constructors
        public static Random rnd = new Random();      //constructor of Random class to generete random numbers
        #endregion

        #region variables
        protected static bool pokracovat = true;
        protected static string vstup = null;
        #endregion

        public static void mathe()
        {
            hc.HdM();
            while (pokracovat)
            {
                vstup = null;
                vstup = hc.Rl();
                vstup = vstup.ToLower();

                switch (vstup)
                {
                    case "help":
                        hc.Wl(" help - vypíše seznam příkazů \n scitani - nástroj pro sčítaní libovolného počtu čísel \n nasobilka - vypíše malou násobilku\n testnasobilka - test na malou násobilku \n nahoda - nástroj pro generování náhodných čísel \n vymazat - vymaže obsah console \n z5 - vrácení do hlavního menu");
                    break;

                    case "scitani":
                    hc.Cl();
                    MultiNumAddCounting();
                    break;

                    case "nasobilka":
                    hc.Cl();
                    SmallTimeing();
                    break;

                    case "testnasobilka":
                    hc.Cl();
                    tryCountingSkill();
                    break;

                    case "nahoda":
                    hc.Cl();
                    getRandomNumbers();
                    break;

                    case "vymazat":
                    hc.Cl();
                    hc.HdM();
                    break;

                    case "z5":
                    pokracovat = false;
                    break;

                    default:
                    hc.Wl("Neplatný příkaz !!!");
                    break;

                }
            }
        }

        public static void MultiNumAddCounting()
        {
            #region //Local Vars
            int MNACa;
            double MNACb;
            double MNACc = 0;
            int i;
            #endregion

            hc.Wl("Zadávejte jen reálná čísla \n");
            hc.W("Počet opakování: ");
            while (!int.TryParse(hc.Rl(), out MNACa))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            for (i = 1; i <= MNACa;i++ )
            {
                hc.W("Zadávejte sčítaná čísla po jednom: ");
                while (!double.TryParse(hc.Rl(), out MNACb))
                { hc.Cl(); hc.W("Zadávejte sčítaná čísla po jednom:  \n Neplatné číslo, zadejte prosím znovu: "); }
                MNACc = MNACb + MNACc;
                hc.Cl();
            }
            hc.Wl("\n výsledek: " + Convert.ToString(MNACc));
        }
        public static void SmallTimeing()
        {
            #region //Local Vars
            #endregion

            {
                for (int j = 1; j <= 10; j++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(j + " * " + i + " = " + i * j+ "\n");

                    }
                }
                Console.ReadKey();
            }
        
        }
        public static void getRandomNumbers()
        {
            #region //Local Vars
            int GRNa = 0, GRNb = 0, GRNc = 0, GRNd = 0, GRNe = 0, GRNf = 0, GRNg = 0; //statictics
            int GRNo; //number of operation
            #endregion

            hc.W("Zadejte počet náhodných čísel které chcete vygenerovat: ");
            while(!int.TryParse(hc.Rl(), out GRNo))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            hc.Cl();
            hc.W("generuji.");
            Thread.Sleep(500);
            hc.Cl();
            hc.W("generuji..");
            Thread.Sleep(500);
            hc.Cl();
            hc.W("generuji...");
            Thread.Sleep(1000);
            hc.Cl();
            if (GRNo != 1)
            { hc.W("Náhodná čísla jsou "); }
            for (int i=1; i <= GRNo; i++)
            {
             GRNg = rnd.Next(1, 6+1);
             if (GRNg == 6)
             { GRNa = GRNa + 1; } 
             else if(GRNg == 5)
             { GRNb = GRNb + 1; }
             else if (GRNg == 4)
             { GRNc = GRNc + 1; }
             else if (GRNg == 3)
             { GRNd = GRNd + 1; }
             else if (GRNg == 2)
             { GRNe = GRNe + 1; }
             else
             { GRNf = GRNf + 1; }
             
             if (GRNo == 1)
             { hc.Wl("náhodné číslo je ´" + GRNg + "´"); }
             else if (i < GRNo)
             { hc.W(GRNg + ","); }
             else
             { hc.W(Convert.ToString(GRNg)); }
            }
            hc.Wl("\n \n \nstatistika jednotlivých čísel \n \n6: " + GRNa + "\n5: " + GRNb + "\n4: " + GRNc + "\n3: " + GRNd + "\n2: " + GRNe + "\n1: " + GRNf);
            hc.Rl();
        }
        public static void tryCountingSkill()
        { 
            #region //Local Vars
            int TCSa, TCSb, TCSc, TCSd, TCSe; //TCSa,TCSb element of counting. TCSc result(true). TCSd result(input). TCSe number of repeats
            int TCSt = 0, TCSf = 0; // TCSt right result of counting. TCSf False result of counting
            #endregion

            hc.Wl("Zadej počet příkladů které chceš počítat");
            while (!int.TryParse(hc.Rl(), out TCSe))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            for (int i = 0; i < TCSe; i++)
            {
                TCSa = rnd.Next(0, 10 + 1);
                Thread.Sleep(10);
                TCSb = rnd.Next(0, 10 + 1);
                hc.Wl("\n\n            " + TCSa + " * " + TCSb);
                TCSc = TCSa * TCSb;
                while (!int.TryParse(hc.Rl(), out TCSd))
                { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
                if (TCSc == TCSd)
                { hc.Wl("\nSprávný výsledek)"); TCSt = TCSt + 1; }
                else
                { hc.Wl("\nŠpatný výsledek"); TCSf = TCSf + 1; }
            }
            hc.Wl("Správných výsledků: " + TCSt + "\nŠpatných výsledků: " + TCSf);
            hc.Rk();

        }
    }
}

/* odkládací místo
    while (!int.TryParse(hc.Rl(), out TCSd))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
   
 ;*             *;
*/