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
                        hc.Wl(" help - vypíše seznam příkazů \n scitani - nástroj pro sčítaní libovolného počtu čísel \n nasobilka - vypíše malou násobilku\n testmalanasobilka - test na malou násobilku \n testvelkanasobilka - test na velkou násobilku\n nahoda - nástroj pro generování náhodných čísel \n vymazat - vymaže obsah console \n z5 - vrácení do hlavního menu");
                    break;

                    case "scitani":
                    hc.Cl();
                    MultiNumAddCounting();
                    break;

                    case "nasobilka":
                    hc.Cl();


                    SmallTimeing();
                    break;

                    case "testmalanasobilka": 
                    hc.Cl();
                    tryCountingSkill();
                    break;

                    case "testvelkanasobilka":
                    hc.Cl();
                    tryMultiplicationSkill();
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
            #region Local Vars
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
        public static void tryCountingSkill() //Made by SnasiCze@ 2014
        {
            #region Local Vars
            string ano;
            int spravne = 0;
            int spravne2 = 0;
            #endregion
                  
            //---------------------------------------------Opakování malé násobylky pomocí cyklu white---------------------------------------------\\                                     
                    do
                    {
                        Console.Clear();
                        Console.Write("Zadej počet příkladů: ");
                        int pocet_prikladu = Convert.ToInt32(Console.ReadLine());
                        //---------------------------------------------Začátek "grafiky"---------------------------------------------\\ 
                        Console.Write("Generuji zadaný počet příkladů na malou násobilku");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(100);
                        //---------------------------------------------Konec "grafiky"---------------------------------------------\\
                        //---------------------------------------------Zde začíná malá násobilka---------------------------------------------\\
                        for (int i = 1; i <= pocet_prikladu; i++)
                        {
                            spravne++;
                            int nahodne_cislo = rnd.Next(1, 11);
                            int nahodne_cislo2 = rnd.Next(1, 11);

                            Console.Write(nahodne_cislo + " * " + nahodne_cislo2 + " = ");
                            int vysledek = Convert.ToInt32(Console.ReadLine());
                            //---------------------------------------------If právná odpověď---------------------------------------------\\
                            if (nahodne_cislo * nahodne_cislo2 == vysledek)
                            {
                                spravne2++;
                                Console.WriteLine("Správně " + spravne2 + "/" + spravne);
                            }
                            //---------------------------------------------špatná odpověď---------------------------------------------\\
                            else
                            {

                                //---------------------------------------------Oprava výsledku---------------------------------------------\\
                                int odpoved = nahodne_cislo * nahodne_cislo2;
                                int vysledek_else = vysledek - nahodne_cislo * nahodne_cislo2;
                                Console.WriteLine("Špatně, napsal jsi o " + vysledek_else + " jiné číslo,správná opověd je: " + odpoved + " máš " + spravne2 + "/" + spravne);
                            }


                        } //---------------------------------------------Vypsání správný a celkových odpovědí---------------------------------------------\\
                        
                        int procenta = 100 * spravne2 / spravne;
                        Console.WriteLine();
                        //---------------------------------------------Známkování---------------------------------------------\\
                        Console.WriteLine("Výsldek " + spravne2 + "/" + spravne);
                        Console.WriteLine("Máš " + procenta + "%");
                        if (procenta > 80)
                        {
                            Console.WriteLine("Máš za 1");
                            Console.WriteLine("Tady to někdo umí");
                        }
                        if (procenta <= 80 && procenta > 60)
                        {
                            Console.WriteLine("Máš za 2");
                            Console.WriteLine("Mohlo to  být trochu lepší");
                        }
                        if (procenta <= 60 && procenta > 40)
                        {
                            Console.WriteLine("Máš za 3");
                            Console.WriteLine("Chělo by to zapracovat");
                        }
                        if (procenta <= 40 && procenta > 20)
                        {
                            Console.WriteLine("Máš za 4");
                            Console.WriteLine("Jako vážně za 4!");
                        }
                        if (procenta <= 20)
                        {
                            Console.WriteLine("Máš za 5");
                            Console.WriteLine("Si úplně blbej (bez urážky)");
                        }
                       
                        Console.WriteLine("Chceš pokračovat? [a/n] ");
                        //---------------------------------------------Opakování malé násobilky---------------------------------------------\\
                        ano = Console.ReadLine();
                    } while (ano.ToLower() == "a");
                     
                     
                }
    
 //-------------------------------------------Velká násobilka--------------------------------------\\
               // if (rozdeleni.ToLower() == "velkou") 
                public static void tryMultiplicationSkill()
                {
                    #region Local Vars
                    string ano;
                    int spravne = 0;
                    int spravne2 = 0;
                    #endregion
                    
                    do
                    {
                        Console.Clear();
                        Console.Write("Zadej počet příkladů: ");
                        int pocet_prikladu = Convert.ToInt32(Console.ReadLine());
                        //---------------------------------------------začátek "grafiky"---------------------------------------------\\ 
                        Console.Write("Generuji zadaný počet příkladů na velkou násobilku");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.Write(".");
                        Thread.Sleep(500);
                        Console.WriteLine(".");
                        Thread.Sleep(100);
                        //---------------------------------------------Konec "grafiky"---------------------------------------------\\
                        
                       
                        for (int i = 1; i <= pocet_prikladu; i++)
                        {
                            
                            spravne++;
                            int nahodne_cislo = rnd.Next(1, 101);
                            int nahodne_cislo2 = rnd.Next(1, 101);

                            Console.Write(nahodne_cislo + " * " + nahodne_cislo2 + " = ");
                            int vysledek = Convert.ToInt32(Console.ReadLine());
                            //---------------------------------------------If právná odpověď---------------------------------------------\\
                            if (nahodne_cislo * nahodne_cislo2 == vysledek)
                            {
                                spravne2++;
                                Console.WriteLine("Správně " + spravne2 + "/" + spravne);
                            }
                            //---------------------------------------------špatná odpověď---------------------------------------------\\
                            else
                            {

                                //---------------------------------------------Oprava výsledku---------------------------------------------\\
                                int odpoved = nahodne_cislo * nahodne_cislo2;
                                int vysledek_else = vysledek - nahodne_cislo * nahodne_cislo2;
                                Console.WriteLine("Špatně, napsal jsi o " + vysledek_else + " jiné číslo,správná opověd je: " + odpoved + " máš " + spravne2 + "/" + spravne);
                            }


                        } //---------------------------------------------Vypsání správných a celkových odpovědí---------------------------------------------\\
                       
                        int procenta = 100 * spravne2 / spravne;
                        Console.WriteLine();
                        //---------------------------------------------Známkování---------------------------------------------\\
                        Console.WriteLine("Výsldek " + spravne2 + "/" + spravne);
                        Console.WriteLine("Máš " + procenta + "%");
                        if (procenta > 80)
                        {
                            Console.WriteLine("Máš za 1");
                            Console.WriteLine("Tady to někdo umí");
                        }
                        if (procenta <= 80 && procenta > 60)
                        {
                            Console.WriteLine("Máš za 2");
                            Console.WriteLine("Mohlo to  být trochu lepší");
                        }
                        if (procenta <= 60 && procenta > 40)
                        {
                            Console.WriteLine("Máš za 3");
                            Console.WriteLine("Chělo by to zapracovat");
                        }
                        if (procenta <= 40 && procenta > 20)
                        {
                            Console.WriteLine("Máš za 4");
                            Console.WriteLine("Jako vážně za 4!");
                        }
                        if (procenta <= 20)
                        {
                            Console.WriteLine("Máš za 5");
                            Console.WriteLine("Si úplně blbej (bez urážky)");
                        }

                        Console.WriteLine("Chceš pokračovat? [a/n] ");
                        //---------------------------------------------Opakování velké násobilky---------------------------------------------\\
                       ano = Console.ReadLine();
                    } while (ano.ToLower() == "a");
                  
                
               
            Console.ReadLine();

        }
    }
}

/* odkládací místo
    while (!int.TryParse(hc.Rl(), out TCSd))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
   
 ;*             *;
*/