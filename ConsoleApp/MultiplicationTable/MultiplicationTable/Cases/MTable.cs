using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable.Cases
{
    internal partial class Case
    {
        internal static void MT()
        {
            Console.WriteLine("********************************************");
            for (int i = 1;i <= 10;i++)
            { 
                for (int j = 1;j <= 10; j++)
                {
                    if ((i*j) < 10 && j != 1)
                        Console.Write($"  {i * j} ");
                    else if(j==1)
                        Console.Write($"* {i * j} ");
                    else if(i==10)
                        Console.Write($" {i * j} ");
                    else
                        Console.Write($"  {i * j}");
                }
                if (i == 10)
                    Console.WriteLine(" *\n*                                          *");
                else
                    Console.WriteLine("   *\n*                                          *");
            }
            Console.WriteLine("********************************************");
        }
    }
}
