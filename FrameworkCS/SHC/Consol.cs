using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHC
{
    public class Consol
    {
        // shorter writeline (wln)
        public static void wln(string text)
        {
            Console.WriteLine(text);
        }
        // shorter Console.Write wl
        public static void wl(string text)
        {
            Console.Write(text);
            
        }
        // Console.Readline Consol.rl Console.ReadKey() Consol.rk
        public static string rl(string text)
        {
         return text;
        }
        public static void rk()
        {
            Console.ReadKey();
        }
        // Console.Beep Consol.Bip
        public static void Bip()
        {
            Console.Beep();
        }

        // Console.Clear Consol.cls
        public static void Cls()
        {
            Console.Clear();
        }
        // Console.Read Consol.r
        public static void r()
        {
            Console.Read();
        }
        
    }
}
