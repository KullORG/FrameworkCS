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
        // Console.Readline Consol.rl Console.ReadKey() Consol.rkn
        public static string rl(string text)
        {
         return text;
        }
        public static void rkn()
        {
            Console.ReadKey();
        }
    }
}
