using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST");
            Console.WriteLine("------------------------------------------------------------------------------");
            double summa;
            bool hinnad = true;
            while (hinnad)
            {
                {
                    Console.Write("Enter price of food item, [-1 to quit]: ");
                    string input = Console.ReadLine();
                    double i = double.Parse(input);

                    if (i == -1)
                    {
                        break;
                    }
                    
                }        
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
        }

    }
}
