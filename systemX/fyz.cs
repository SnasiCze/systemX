using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemX
{
    class fyz
    {

        #region variables
        protected static bool pokracovat = true;
        protected static string vstup = null;
        #endregion

        public static void fyzika()
        {
            hc.HdF();
            while (pokracovat)
            {
                vstup = null;
                vstup = hc.Rl();
                vstup = vstup.ToLower();

                switch (vstup)
                {
                    case "help":
                        hc.Wl(" help - vypíše seznam příkazů \n vykon - výpočet výkonu \n vymazat - vymaže obsah console \n z5 - vrácení do hlavního menu");
                    break;

                    case "vykon":
                    vykon();
                    break;

                    case "vymazat":
                    hc.Cl();
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

        public static void vykon()
        {

            #region //Local Vars
            double Va; //Mass
            double Vb; //length
            double Vc; //Time
            double Ve; //Result
            const double Vd = 10; //Grav. const
            #endregion

            hc.Wl("jednotky uvádějte v základních jednotkách \n");
            hc.W("hmotnost: ");
            while (!double.TryParse(hc.Rl(), out Va))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            hc.W("délka: ");
            while (double.TryParse(hc.Rl(), out Vb))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            hc.W("čas(ve vteřinách): ");
            while (double.TryParse(hc.Rl(), out Vc))
            { hc.Cl(); hc.W("Neplatné číslo, zadejte prosím znovu: "); }
            Ve = Va * Vb * Vd / Vc;
            hc.Wl(Convert.ToString(Ve + " Wattů"));
            hc.Rk();
            hc.Cl();
            hc.HdF();
        }
    }
}
