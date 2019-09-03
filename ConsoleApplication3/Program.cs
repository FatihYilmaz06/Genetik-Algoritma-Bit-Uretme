using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;

namespace yapayZeka
{
    class Program
    {
        

        static void Main(string[] args)
        {
          
            parent deneme = new parent();
            double[,] dizi = new double[40, 3];
           
            {
                
                {
                    
                    for (int i = 0; i < 20; i++)
                    {   


                        int saat = Convert.ToInt32(DateTime.Now.Hour);
                        int gun = Convert.ToInt32(DateTime.Now.Day);
                        int saniye = Convert.ToInt32(DateTime.Now.Millisecond);
                        int dakika = Convert.ToInt32(DateTime.Now.Minute);
                        double xn = random.xdeger(saat, gun, saniye, dakika);
                        double a = random.adeger(saat, gun, saniye, dakika);
                        double asdf =(deneme.ata(xn, a));
                        if (asdf <= 1500)
                        {
                            dizi[i, 0] = xn;
                            dizi[i, 1] = a;
                            dizi[i, 2] = asdf;
                            Console.WriteLine("A değeri = " + a);
                            Console.WriteLine("Xn değeri = " + xn);
                            Console.WriteLine("Aradaki fark = " + asdf);
                            Console.WriteLine(i + ". iterasyon da bulundu");
                            break;
                        }
                                        
                        
                    }
                }


            }
            double[] yeni = new double[20];
            for (int i = 0; i < 20; i++)
            {
                yeni[i] = dizi[i, 2];
            }
            Array.Sort(yeni);

            double[,] caprazla = new double[2, 3];
            foreach (int i in yeni)
            {
                if (i < 2)
                {
                    if (yeni[i] == dizi[i, 2])
                    {
                        caprazla[0, 0] = dizi[i, 0];
                        caprazla[0, 1] = dizi[i, 1];
                        caprazla[0, 2] = dizi[i, 2];
                    }
                }
            }

            Console.ReadLine();

        }



    }
}
