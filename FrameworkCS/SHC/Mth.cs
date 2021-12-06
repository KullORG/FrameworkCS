using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHC
{
    public class Mth
    {
        // Math.Round shorter. Mth.Rnd
        public static double Rnd(double num)
        {
            return Math.Round(num);
            
        }
        // Math.Sin Mth.Sin
        public static double Sin(double num) { return Math.Sin(num); }
        // Math.Cos Mth.Cos
        public static double Cos(double num) { return Math.Cos(num); }
        // Math.Pow Mth.pow
        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
