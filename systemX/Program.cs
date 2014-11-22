using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace systemX
{
    class Program
    {
        
        static void Main(string[] args)
        {   restart:
            /*Co je co ? 
            hc.Wl    Je skrácení zápisu Console.WriteLine(""); a zapisuje se stejně.
            hc.Rl    Je skrácení zápisu Console.ReadLine(); a zapisuje se stejně.
            hc.Rk    Je skrácení zápisu Console.ReadKEy(); a zapisuje se stejně.
            hc.Hd    Je skrácení zápisu Console.WriteLine("System X");
            */
            // konstroktory
            
            math math = new math();
            //
            //deklarace
            bool pokracovat = true;
            string vstup;
            //
            hc.Wl("Výtejte v systému X \nver. 1.5.2.3 \npro vypsání příkazů napište help");
            while (pokracovat)
            {
                vstup = null;
                vstup = hc.Rl();
                vstup = vstup.ToLower();

                switch (vstup)
                {
                    case "help":
                        hc.Wl(" help - vypíše seznam příkazů \n math - otevře možnost pro výpočet matematických problémů \n fyz - otevře možnost pro výpočet fyzikálních jevů \n vymazat - vymaže obsah console \n vypnout - vypne program");
                        break;
                        
                    case "fyz":
                        hc.Cl();
                        fyz.fyzika();
                        hc.Cl();
                        hc.Hd();
                        break;

                    case "math":
                        hc.Cl();
                        math.mathe();
                        hc.Cl();
                        hc.Hd();
                        break;

                    case "beep":
                        hc.Bp();
                        break;

                    case "vypnout":
                        pokracovat = false;
                        break;

                    case "vymazat":
                        hc.Cl();
                        hc.Hd();
                        break;

                    case "restart":
                        hc.Cl();
                        hc.Wl("Počkejte prosím než se System X znovu načte");
                        Thread.Sleep(2000);
                        hc.Cl();
                        Thread.Sleep(500);
                        goto restart;

                    default:
                        hc.Wl("Neplatný příkaz !!!");
                        break;

                }
            }
        }
    }
}
