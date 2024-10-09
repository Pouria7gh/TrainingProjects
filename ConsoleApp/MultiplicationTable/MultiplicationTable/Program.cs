using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiplicationTable.Cases;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Exit = true;
            while (Exit)
            {
                Console.WriteLine("Menu :");
                Console.WriteLine("Enter \"1\" To See The Multipication Table");
                Console.WriteLine("Enter \"2\" To See Student Information");
                Console.WriteLine("Enter \"0\" To Exit");
                string Menu = Console.ReadLine();
                int _Menu = int.Parse(Menu);
                if (_Menu <3 && _Menu >= 0)
                {
                    switch (_Menu)
                    {
                        case 0:
                            Console.WriteLine("\nThanks you For Checking This Out !!\n");
                            Exit = false;
                            Console.ReadKey();
                            break;
                        case 1:
                            Case.MT();
                            break;
                        case 2:
                            Case.Info();
                            break;
                    }
                }
                else
                    throw new Exception("Wrong Format Please Try Again");
                
            }
        }
    }
}
