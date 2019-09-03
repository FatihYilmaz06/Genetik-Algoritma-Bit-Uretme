using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;
using System.Threading;

namespace yapayZeka
{
    public class parent
    {



        public double ata(double xn, double a)
        {
            double[] asd = new double[1000000];
            asd[0] = parent.parametre(xn, a);
            for (int i = 1; i < 1000000; i++)
            {
                //Console.WriteLine(i + ". eleman" + ongen[i]);
                object k = asd[i - 1];
                double ab = Convert.ToDouble(k);
                //ongen.Add(parametre(ab ,a));
                asd[i] = parent.parametre(ab, a);
            }
            int sayac0 = 0;
           
            int sayac1 = 0;
            int[] dizi = new int[asd.Length];
            for (int i = 0; i < asd.Length; i++)
            {
                //    object k = asd[i];
                //    double ab = Convert.ToDouble(k);
                if (asd[i] < 0.5)
                {
                    asd[i] = 0;
                    dizi[i] = Convert.ToInt32(asd[i]);
                    sayac0++;
                }
                else
                {
                    asd[i] = 1;
                    dizi[i] = Convert.ToInt32(asd[i]);
                    sayac1++;
                }
                //Console.WriteLine(dizi[i]);
            }
            int xc = 0;
            int[] gen = new int[dizi.Length / 4];
            for (int j = 0; j < gen.Length; j++)
            {
                int ka = 0;
                for (int i = 1; i <= 4; i++)
                {
                    if (i % 4 == 1)
                    {
                        ka = ka + dizi[xc] * 8;
                        xc++;
                    }
                    else if (i % 4 == 2)
                    {
                        ka = ka + dizi[xc] * 4;
                        xc++;
                    }
                    else if (i % 4 == 3)
                    {
                        ka = ka + dizi[xc] * 2;
                        xc++;
                    }
                    else
                    {
                        ka = ka + dizi[xc] * 1;
                        xc++;
                    }
                }
                gen[j] = ka;
            }
            int saya0 = 0;
            int saya1 = 0;
            int saya2 = 0;
            int saya3 = 0;
            int saya4 = 0;
            int saya5 = 0;
            int saya6 = 0;
            int saya7 = 0;
            int saya8 = 0;
            int saya9 = 0;
            int saya10 = 0;
            int saya11 = 0;
            int saya12 = 0;
            int saya13 = 0;
            int saya14 = 0;
            int saya15 = 0;
            for (int i = 0; i < gen.Length; i++)
            {
                if (gen[i] == 0)
                {
                    saya0++;
                }
                else if (gen[i] == 1)
                {
                    saya1++;
                }
                else if (gen[i] == 2)
                {
                    saya2++;
                }
                else if (gen[i] == 3)
                {
                    saya3++;
                }
                else if (gen[i] == 4)
                {
                    saya4++;
                }
                else if (gen[i] == 5)
                {
                    saya5++;
                }
                else if (gen[i] == 6)
                {
                    saya6++;
                }
                else if (gen[i] == 7)
                {
                    saya7++;
                }
                else if (gen[i] == 8)
                {
                    saya8++;
                }
                else if (gen[i] == 9)
                {
                    saya9++;
                }
                else if (gen[i] == 10)
                {
                    saya10++;
                }
                else if (gen[i] == 11)
                {
                    saya11++;
                }
                else if (gen[i] == 12)
                {
                    saya12++;
                }
                else if (gen[i] == 13)
                {
                    saya13++;
                }
                else if (gen[i] == 14)
                {
                    saya14++;
                }
                else if (gen[i] == 15)
                {
                    saya15++;
                }
            }
            int tplsaya0 = Math.Abs(15625 - saya0);
            int tplsaya1 = Math.Abs(15625 - saya1);
            int tplsaya2 = Math.Abs(15625 - saya2);
            int tplsaya3 = Math.Abs(15625 - saya3);
            int tplsaya4 = Math.Abs(15625 - saya4);
            int tplsaya5 = Math.Abs(15625 - saya5);
            int tplsaya6 = Math.Abs(15625 - saya6);
            int tplsaya7 = Math.Abs(15625 - saya7);
            int tplsaya8 = Math.Abs(15625 - saya8);
            int tplsaya9 = Math.Abs(15625 - saya9);
            int tplsaya10 = Math.Abs(15625 - saya10);
            int tplsaya11 = Math.Abs(15625 - saya11);
            int tplsaya12 = Math.Abs(15625 - saya12);
            int tplsaya13 = Math.Abs(15625 - saya13);
            int tplsaya14 = Math.Abs(15625 - saya14);
            int tplsaya15 = Math.Abs(15625 - saya15);
            //int IhopeThisMin = tplsaya0 + tplsaya1 + tplsaya2 + tplsaya3 + tplsaya4 + tplsaya5 + tplsaya6 + tplsaya7 + tplsaya8 + tplsaya9 +
            //    tplsaya10 + tplsaya11 + tplsaya12 + tplsaya13 + tplsaya14 + tplsaya15;

            double qwe = (Convert.ToInt32(tplsaya0 + tplsaya1 + tplsaya2 + tplsaya3 + tplsaya4 + tplsaya5 + tplsaya6 + tplsaya7 + tplsaya8 + tplsaya9 + tplsaya10 + tplsaya11 + tplsaya12 + tplsaya13 + tplsaya14 + tplsaya15) / 16);

            Console.WriteLine("0lar" + sayac0);
            Console.WriteLine("1lar" + sayac1);
            Console.WriteLine("0lar" + saya0);
            Console.WriteLine("1lar" + saya1);
            Console.WriteLine("2lar" + saya2);
            Console.WriteLine("3lar" + saya3);
            Console.WriteLine("4lar" + saya4);
            Console.WriteLine("5lar" + saya5);
            Console.WriteLine("6lar" + saya6);
            Console.WriteLine("7lar" + saya7);
            Console.WriteLine("8lar" + saya8);
            Console.WriteLine("9lar" + saya9);
            Console.WriteLine("10lar" + saya10);
            Console.WriteLine("11lar" + saya11);
            Console.WriteLine("12lar" + saya12);
            Console.WriteLine("13lar" + saya13);
            Console.WriteLine("14lar" + saya14);
            Console.WriteLine("15lar" + saya15);
            //Console.ReadLine();
            Thread.Sleep(500);
            return qwe;
        }
        public static double parametre(double xn, double a)
        {
            if (xn >= 1)
            {
                xn = xn - 0.005;
                return xn;
            }
            else
            {
                xn = xn * a * (1 - xn);
                return xn;
            }
        }
    }
}
