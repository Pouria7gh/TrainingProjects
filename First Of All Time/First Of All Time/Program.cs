using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Of_All_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tedad Dars Ha Ra Vared Konid");
            int Tedad = 0;
            String sTedad = Console.ReadLine();
            while (!int.TryParse(sTedad, out Tedad))
            {
                Console.WriteLine("Format Eshtebah Ast Dobare Talash Konid");
                sTedad = Console.ReadLine();
            }
            Console.WriteLine("Nomarat Ra Vared Konid (az 0 ta 20)");
            int i = 0;
            double[] Nomarat = new double[Tedad];
            while (i<Tedad)
            {
                try
                {
                    Console.WriteLine("Nomre {0} :",i+1);
                    Double Nomre = Convert.ToDouble(Console.ReadLine());
                    if (Nomre>=0 && Nomre<21)
                    {
                        Nomarat[i] = Nomre;
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("Format Eshtebah Ast Dobare Talash Konid");
                }
            }
            double sum = 0;
            int p = 1;
            Console.WriteLine("Nomarat Shoma Ebaratand Az : ");
            foreach  (double nomre in Nomarat)
            {
                Console.WriteLine("Nomre {0} : {1}",p,nomre);
                sum = nomre + sum;
                p++;
            }
            Console.WriteLine("Moadele Shoma : {0}",sum/Tedad);
            Console.ReadLine();
        }
    }
}
