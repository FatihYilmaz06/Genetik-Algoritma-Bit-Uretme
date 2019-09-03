using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics.Contracts;
namespace yapayZeka
{
    public class random
    {
        public static double adeger(double saat, double gun, double saniye, double dakika)
        {
            //int k = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double x = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double b = 4 - 3.5;
            double a = b / 46640000;
            a = (a * x) + 3.9;
            return a;
        }
        public static double xdeger(double saat, double gun, double saniye, double dakika)
        {
            //int k = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double x = (saat + 1) * gun * (saniye + 1) * (1 + dakika);
            double b = 1;
            double a = b / 46640000;
            a = (a * x) + 0.9;
            return a;
        }


        //}
    }
}