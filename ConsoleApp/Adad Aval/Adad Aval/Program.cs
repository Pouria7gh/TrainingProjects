using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adad_Aval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adad ra wared konid");
            String StringNum = Console.ReadLine();
            int num = int.Parse(StringNum);
            int counter = 0;
 
            for (int index = 1 ; index<=num ; ++index)
            {
                int a = num % index;
                if (a == 0)                 
                        ++counter;
            }
            
            if (counter == 2)
            {
                Console.WriteLine("Adad aval ast");
            }
            else
            {
                Console.WriteLine("Adad aval nist");
            }
            Console.ReadLine();
        }
    }
}
