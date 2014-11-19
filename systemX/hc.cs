using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemX
{
    public class hc
    {
        public static void Wl(string text)
        {
            Console.WriteLine(text);
        }
        public static void W(string text2)
        {
            Console.Write(text2);
        }
        public static string Rl()
        {
            string text3 = Console.ReadLine();
            return text3;
        }
        public static void Rk()
        {
            Console.ReadKey();
        }
        public static void Hd()
        {
            Console.WriteLine("System X \nver.1.4.1.3");
        }
        public static void Cl()
        {
            Console.Clear();
        }
        public static void Debug()
        {
            Console.WriteLine("############################## \n DEBUG - LINE \n ##############################");
        }
        public static void HdF()
        {
            Console.WriteLine("System X - Fyzika \n");
        }
        public static void HdM()
        {
            Console.WriteLine("System X - Matematika \n");
        }
        public static void Bp()
        {
            Console.Beep(4000,3000);
        }
    }
}
